using Final_Project.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.DTO
{
    public class Customer : Observer
    {
        public Customer(int id, string fname, string lname,  string gender, string phone,string email)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;         
            this.Gender = gender;
            this.Phone = phone;
            this.Email = email;   
        }
        public Customer(DataRow row)
        {
            this.Id = (int)row["IDCus"];
            this.Fname = row["FirstN"].ToString();
            this.Lname = row["LastN"].ToString();
            this.Gender = row["Gender"].ToString();
            this.Phone = row["Phone"].ToString();
            this.Email = row["Email"].ToString();
          
        }
        public override void ObserverInfo(string info)
        {

            sentmail(Fname, Lname, Phone, Email, info);
                 
        }
        void sentmail(string fname,string lname,string phone, string email, string info)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("kaitrung99@gmail.com", "daucoaibiet123");
                MailMessage msg = new MailMessage();
                msg.To.Add(email);
                msg.From = new MailAddress("kaitrung99@gmail.com");
                msg.Subject = "Cập nhật sản phẩm từ cửa hàng Việt - Trung";
                msg.Body = "Thông báo đến : " + fname +" "+lname+ "    "+ "Có số điện thoại :" +phone+" Thông tin sản phẩm vừa cập nhật :   " + info;
                client.Send(msg);
                
            }
            catch 
            {
                MessageBox.Show("Kết nối internet có vấn đề !");
            }
        }

        private int id;
        private string fname;
        private string lname;
      
        private string gender;
        private string phone;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}
