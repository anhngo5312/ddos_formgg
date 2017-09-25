using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Collections.Specialized;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] FIM = new string[] { "Nguyễn Xuân Việt", "Lê Hoàng Cường", "Phạm Tất Đạt", "Nguyễn Ngọc Đức", "Dương Công Đức Linh", "Lê Đức Thắng ", "Phạm Đức Văn ", "Nguyễn Bá Quyết Thắng", "Đặng Tuấn Vũ", "Khổng Lan Anh", "Nguyễn Thị Thu", "Nguyễn Trọng Tú", "Lê Đặng Duyệt" };
            string[] FHO = new string[] { " Trương Gia Bình", "Đỗ Cao Bảo", "Bùi Quang Ngọc", "Nguyễn Thế Phương", "Dương Dũng Triều", "Nguyễn Khắc Thành", "Hoàng Việt Hà", "Lê Hồng Việt" };
            string[] CHUNGTA = new string[] { "Vu Thi  Ha", "Dao Thi Bich Huyen", "Nguyen Thanh Nga", "Luu Thi Binh Nguyen", "Nguyen Thi Nhan", "Tran Thi Lam Thao", "Nguyen Thanh Tu", "Ha Thanh Tung", "Luu Thi Van", "Nguyen Tan Viet" };
            string[] FAF = new string[] { "Bui Thi Van Anh", "Vuong Tuan Anh", "Hoang HuuChien", "Tran Manh Cuong", "Truong Linh Da", "Nguyen Tien Hao", "Vu Thi Lan Huong", "La Hung Hai", "Luong Quoc Lan", "Pham Duy Hoang Nam", "Nguyen Thi Viet Nga" };
            string[] FHR = new string[] { "Chu Phuong Anh", "Pham Hoang Anh", "Tran Nguyen Tuan Anh", "Tran Thi Thu Ha", "Bui Thu Hang", "Giang Trung  Hieu", "Trinh Thu Hong", "Vo Thi Huong Lan", "Doan Huyen Ly", "Vu Quang Sang", "Nguyen Anh Son", "Nguyen Khanh Tiep", "Dau Thi Quynh Trang", "Le Thuy Trang" };
            string[] FAD = new string[] { "Nguyen Mai Anh", "Pham Ngoc Anh", "Nguyen Kim Chi", "Nguyen Hoai Diep", "Nguyen Thu Hien", "Nguyen Thi Hoa", "Nguyen Thanh Hong", "Le Viet Hung", "Phan Thi Hong Khanh", "Tran Hieu Le", "Pham Ha Linh", "Dinh Thi Thanh Mai", "Tran Dinh Mai", "Trinh Anh Phuong", "Tran Thi Phuong Quyen", "Tran Danh  Toan", "Tran Thi Huyen  Trang", "Tran Thu Trang", "Vu Thanh Trong" };
            string[] FCC = new string[] { "Mai Thi Lan Anh", "Pham Thi Van Anh", "Bui Nguyen Phuong Chau", "Le Thi Thuy Duong", "Phung Thi Bich Hai", "Hoa Vu", "Nguyen Hue Linh", "Ta Duc Thanh", "Truong Thi Phuong Thao", "Nguyen Thi Hop Trang", "Ngo Anh Tuan" };
            string[] FCU = new string[] { "Nguyen Kim Anh", "Tran Thi Minh Hai", "Dao Thi Thanh Lam", "Tran Dieu  Linh", "Ngo Thi Duy Phuong", "Pham Thi Sanh", "Nguyen Thanh  Tu", "Tran Thi Vinh" };
            string[] FTI = new string[] { "Ly Tuan  Anh", "Tran Tuan  Anh", "Vu Quang Chien", "Nguyen Thi Chuc", "Nguyen Viet Cuong", "Nguyen Anh Duc", "Nguyen Minh Duc", "Vu Hoang  Dung", "Tran Hong Duong", "Duong Thanh  Hai", "Nguyen Minh Hanh", "Ha Trung  Hieu", "Vo Thanh Hieu", "Do Quang  Huy", "Lai Thi ThuHuyen", "Hoang Nam Le", "Nguyen Thi Phuong Lien", "Dinh Van Long", "Tran Duc  Long", "Nguyen Dang  Minh", "Nguyen Ngoc Minh", "Mai Thanh  Nga", "Dong Thi Ngan", "Nguyen Bich 9 Ngoc", "Phan Hong Ngoc", "Quach Minh Ngoc", "Le Hong Phuong", "Nguyen Hong Phuong", "Bui Tan Quang", "Bui Hong Son", "Nguyen Khac Thanh", "Nguyen Trung  Thanh", "Vu Cong  Thanh", "Nguyen Thi Thao", "Duong Dung Trieu", "Dao Thuy Trinh", "Nguyen Duc Trung", "Nguyen Huu  Trung", "Pham Van  Trung", "Pham Thi Cam Tu", "Le Ngoc  Tuan", "Le Manh  Tung", "Doan Thanh Vinh", "Dang Hoang Vu", "Hoang Vu" };
            // Random 
            //Random rnd = new Random();
            //string a = names[rnd.Next(0, names.Length - 1)];
            //Console.WriteLine("{0}", a);
            //Console.ReadKey();
            /*foreach (string x in FTI)
            {
                Console.WriteLine(x);
                WebClient client = new WebClient();
                var keyValue = new NameValueCollection();
                keyValue.Add("entry.950940938", x);
                keyValue.Add("entry.2122043918", "FTI");
                keyValue.Add("entry.2120818967", "Nguyễn Bá Quyết Thắng (FIM)");
                keyValue.Add("entry.1584509499", "Đinh Công Sáng (FUN) -");
                keyValue.Add("entry.346349266", "Nguyễn Xuân Viêt (FIM)");
                keyValue.Add("entry.1258724947", "Hoàng Nam Lê (FTI) - Nguyễn Huệ Linh (FCC)");
                keyValue.Add("entry.1213794732", "Nguyễn Thị Vân Anh (FUN)");
                Uri uri = new Uri("https://docs.google.com/forms/d/e/1FAIpQLScx_I84kXAMOJeimXZU3GB4kAPBuIN9Oao2UbFl-H8NRreaGQ/formResponse");
                byte[] response = client.UploadValues(uri, "POST", keyValue);
                string result = Encoding.UTF8.GetString(response);

            }*/
            /*for (int x = 0; x < 1; x++)
            {
                Console.WriteLine(x);
                WebClient client = new WebClient();
                var keyValue = new NameValueCollection();
                keyValue.Add("entry.950940938", "quyên thú :3");
                Uri uri = new Uri("https://docs.google.com/forms/d/e/1FAIpQLSfLaWL1Z5ccrUdnnLXcIlvthMNOJM1QUARIrOrR_V3UPZtVbw/formResponse");
                byte[] response = client.UploadValues(uri, "POST", keyValue);
                string result = Encoding.UTF8.GetString(response);
            }*/

            foreach (string x in FTI)
            {
                Console.WriteLine(x);
                WebClient client = new WebClient();
                var keyValue = new NameValueCollection();
                keyValue.Add("entry.1088280727", x);
                keyValue.Add("entry.2124673546", "đồng ý anh anh làm tổng giám đốc");
                Uri uri = new Uri("https://docs.google.com/forms/d/e/1FAIpQLSeuXFmFhEWvhXBLTlNhJQ7P2R0Q5LShjmAmbXgWtn-Xav_N6Q/formResponse");
                byte[] response = client.UploadValues(uri, "POST", keyValue);
                string result = Encoding.UTF8.GetString(response);
            }
        }

    }
}
