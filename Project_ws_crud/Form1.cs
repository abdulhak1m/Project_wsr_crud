using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Project_ws_crud
{
    public partial class Form1 : Form
    {
        static string myConnection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            // метод передвижения форсы
            Top_pnl();
            // переключение между панеля
            switch_add.Click += (s, e) => { Panel(pnl_Add); };
            switch_edit.Click += (s, e) => { Panel(pnl_edit); };
            switch_deleted.Click += (s, e) => { Panel(pnl_Deleted); };
            // закрыть программу
            btn_close.Click += (s, e) =>
            {
                DialogResult  dialogResult = MessageBox.Show("Вы действительно хотите закрыть программу?", "Уведомление системы",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                    Close();
            };
        }

        void Panel(Panel panel){ panel.BringToFront(); }

        void Top_pnl()
        {
            int move = 0, moveX = 0, moveY = 0;
            pnl_Top.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            pnl_Top.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            pnl_Top.MouseUp += (s, e) => { move = 0; };
        }
        void MessageAsterisk(string line)
        {
            MessageBox.Show(line, "Уведомление системы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        void CleraRow()
        {
            txt_name.Text = "";
            txt_surname.Text = "";
            cmd_gender.Text = "";
            txt_phone.Text = "";
            txt_instagram.Text = "";
            txt_group.Text = "";
        }

        public bool Insert()
        {
            bool IsSuccess = false;
            try
            {
                using (SqlConnection sql = new SqlConnection(myConnection))
                {
                    sql.Open();
                    string query = $"INSERT INTO db_table ([Имя], [Фамилия], [Пол], [Телефон], [instagram], [Группа]) VALUES ('{txt_name.Text}', '{txt_surname.Text}', '{cmd_gender.Text}', '{txt_phone.Text}', '{txt_instagram.Text}', '{txt_group.Text}')";
                    SqlCommand command = new SqlCommand(query, sql);
                    int row = command.ExecuteNonQuery();
                    IsSuccess = row > 0 ? true : false;
                    CleraRow();
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка!", ex.Source); }
            return IsSuccess;
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = Insert();
                MessageAsterisk(success ? "Данные сохранены!" : "Ошибка!");
                listBox1.Items.Clear();
                Listbox();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка!", ex.Source); }
        }

        private async void Listbox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(myConnection))
            {
                await sqlConnection.OpenAsync();
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM db_table", sqlConnection);
                try
                {
                    sqlReader = await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {

                        listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "    " + Convert.ToString(sqlReader["Имя"]) + "    " + Convert.ToString(sqlReader["Фамилия"]) + "    " + Convert.ToString(sqlReader["Пол"]) + "    " + Convert.ToString(sqlReader["Телефон"]) + "    " + Convert.ToString(sqlReader["instagram"]) + "    " + Convert.ToString(sqlReader["Группа"]));
                    }
                }
                catch (Exception ex) { MessageBox.Show("Что-то пошло не так!", ex.Source); }
                finally { if (sqlReader != null) { sqlReader.Close(); } }
            }
        }
        void Form1_Load(object sender, EventArgs e) => Listbox();
    }
}
