using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Font = Xceed.Document.NET.Font;
using Paragraph = Xceed.Document.NET.Paragraph;
using System.Drawing;

namespace Vehicle_license_plate_recognition.Controller
{
    internal class PrintWord
    {
        public bool ExportWord(int idcontact,string NameStaff, string NameCustomer,string PhoneCustomer, string email, 
            string totalValue, DateTime createTime , DateTime ExpiryDate)
        {
            try
            {
                string fileName = @"F:\export_word_HD1.docx";
                var doc = DocX.Create(fileName);

                #region 1 title
                //Formatting Title  
                string title = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM \n Độc Lập – Tự Do – Hạnh Phúc \n \n HỢP ĐỒNG THUÊ XE \n \n Số:" + idcontact + "–HĐTX";

                //Formatting Title  
                // like using this we can set font family, font size, position, font color etc

                Formatting titleFormat = new Formatting();
                //Specify font family  
                titleFormat.FontFamily = new Font("Times New Roman");
                //Specify font size  
                titleFormat.Size = 20D;
               
                titleFormat.FontColor = Color.Black;
                titleFormat.Spacing = 1;
                titleFormat.Bold = true;

                //Insert title  
                Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
                paragraphTitle.Alignment = Alignment.center;

                #endregion

                #region 2 subTitle
                DateTime dt = DateTime.Now;
                int date = dt.Day;
                int month = dt.Month;
                int year = dt.Year;
                //Formatting Title  
                string subTitle = "-         Căn cứ Bộ Luật Dân sự số 33/2005/QH 11 đã được Quốc Hội nước Cộng Hòa Xã Hội Chủ Nghĩa Việt Nam khóa XI, kỳ họp thứ 7 thông qua ngày 14/06/2005; \n" +
                    "-         Căn cứ luật thương mại số 36/2005/QH 11 đã được Quốc Hội nước Cộng Hòa Xã Hội Chủ Nghĩa Việt Nam khóa XI, kỳ họp thứ 7 thông qua ngày 14/06/2005; \n" +
                    "-         Căn cứ vào nhu cầu và khả năng cung ứng của các bên dưới đây.\n" +
                    "Hôm nay, ngày " + date + " tháng " + month + " năm " + year + ", chúng tôi gồm :\n";

                //Formatting Title  
                // like using this we can set font family, font size, position, font color etc

                Formatting subTitleFormat = new Formatting();
                //Specify font family  
                subTitleFormat.FontFamily = new Font("Times New Roman");
                //Specify font size  
                subTitleFormat.Size = 12D;
                //subTitleFormat.Position = 40;
                subTitleFormat.FontColor = Color.Black;
                subTitleFormat.Spacing = 1;
                subTitleFormat.Italic = true;
                //Insert title  
                Paragraph paragraphsubTitle = doc.InsertParagraph(subTitle, false, subTitleFormat);


                #endregion
                #region 3 object

                //Formatting Title  
                string objecttt = "BÊN A: (Bên thuê) \n\n" +
                    "   -         Đại diện: " + NameStaff + "\t - Chức vụ: Nhân viên văn phòng\n\n" +
                    "BÊN B: (Bên cho thuê)\n" +
                    "   -         Tên đầy đủ: " + NameCustomer + "\n" +
                    "   -         Điện thoại: " + PhoneCustomer + "\n" +
                    "   -         Email: " + email + "\n\n";

                //Formatting Title  
                // like using this we can set font family, font size, position, font color etc

                Formatting objectFormat = new Formatting();
                //Specify font family  
                objectFormat.FontFamily = new Font("Times New Roman");
                //Specify font size  
                objectFormat.Size = 12D;
                //subTitleFormat.Position = 40;
                objectFormat.FontColor = Color.Black;
                objectFormat.Spacing = 1;
                objectFormat.Bold = true;
                //Insert title  
                Paragraph paragraphobject = doc.InsertParagraph(objecttt, false, objectFormat);
                #endregion

                #region 4 subObject

                //Formatting Title  
                string subObject = "    Sau khi bàn bạc, thỏa thuận, hai bên thống nhất ký kết Hợp đồng thuê xe với các điều khoản như sau:\n";

                //Formatting Title  
                // like using this we can set font family, font size, position, font color etc

                Formatting subObjectFormat = new Formatting();
                //Specify font family  
                subObjectFormat.FontFamily = new Font("Times New Roman");
                //Specify font size  
                subObjectFormat.Size = 12D;
                //subTitleFormat.Position = 40;
                subObjectFormat.FontColor = Color.Black;
                subObjectFormat.Spacing = 1;

                //Insert title  
                Paragraph paragraphsubObject = doc.InsertParagraph(subObject, false, subObjectFormat);
                #endregion

                #region 5 dieu1


                string dieu1 = "ĐIỀU 1 : NỘI DUNG HỢP ĐỒNG\n";



                Formatting dieu1Format = new Formatting();

                dieu1Format.FontFamily = new Font("Times New Roman");

                dieu1Format.Size = 12D;

                dieu1Format.FontColor = Color.Black;
                dieu1Format.Bold = true;
                dieu1Format.Spacing = 1;

                Paragraph paragraphdieu1 = doc.InsertParagraph(dieu1, false, dieu1Format);
                #endregion


                #region 5 dieu1


                string dieu1Content = "Bên A đồng ý thuê của bên B thuê một xe ô tô.\n";



                Formatting dieu1ContentFormat = new Formatting();

                dieu1ContentFormat.FontFamily = new Font("Times New Roman");

                dieu1ContentFormat.Size = 12D;

                dieu1ContentFormat.FontColor = Color.Black;

                dieu1ContentFormat.Spacing = 1;

                Paragraph paragraphdieu1Content = doc.InsertParagraph(dieu1Content, false, dieu1ContentFormat);
                #endregion

                #region 5 dieu2


                string dieu2 = "ĐIỀU 2 : GIÁ TRỊ HỢP ĐỒNG, PHƯƠNG THỨC THANH TOÁN:\n";



                Formatting dieu2Format = new Formatting();

                dieu2Format.FontFamily = new Font("Times New Roman");

                dieu2Format.Size = 12D;

                dieu2Format.FontColor = Color.Black;
                dieu2Format.Bold = true;
                dieu2Format.Spacing = 1;

                Paragraph paragraphdieu2 = doc.InsertParagraph(dieu2, false, dieu2Format);
                #endregion


                #region 6 dieu2


                string dieu2Content = "- Giá thuê xe là: " + totalValue + " đồng (VND)\n" +
                    "( Giá trên đã bao gồm thuế GTGT )\n" +
                    "- Bên A sẽ thanh toán cho Bên B theo (Hình thức thanh toán) .";



                Formatting dieu2ContentFormat = new Formatting();

                dieu2ContentFormat.FontFamily = new Font("Times New Roman");

                dieu2ContentFormat.Size = 12D;

                dieu2ContentFormat.FontColor = Color.Black;
                dieu2ContentFormat.Spacing = 1;


                Paragraph paragraphdieu2Content = doc.InsertParagraph(dieu2Content, false, dieu2ContentFormat);
                #endregion


                #region 7 dieu3


                string dieu3 = "ĐIỀU 3 : TRÁCH NHIỆM CỦA CÁC BÊN:";



                Formatting dieu3Format = new Formatting();

                dieu3Format.FontFamily = new Font("Times New Roman");

                dieu3Format.Size = 12D;

                dieu3Format.FontColor = Color.Black;
                dieu3Format.Bold = true;
                dieu3Format.Spacing = 1;

                Paragraph paragraphdieu3 = doc.InsertParagraph(dieu3, false, dieu3Format);
                #endregion


                #region 8 dieu3.1


                string dieu31 = "3.1. Trách nhiệm của bên B:";



                Formatting dieu31Format = new Formatting();

                dieu31Format.FontFamily = new Font("Times New Roman");

                dieu31Format.Size = 12D;

                dieu31Format.FontColor = Color.Black;
                dieu31Format.Bold = true;
                dieu31Format.Italic = true;
                dieu31Format.Spacing = 1;

                Paragraph paragraphdieu31 = doc.InsertParagraph(dieu31, false, dieu31Format);
                #endregion

                #region 9 dieu3.1


                string dieu31Content = "-         Giao xe và toàn bộ giấy tờ liên quan đến xe ngay sau khi Hợp đồng có hiệu lực và Bên A đã thanh toán tiền thuê xe 01 tháng đầu tiên. Giấy tờ liên quan đến xe gồm: Giấy đăng ký xe, giấy kiểm định, giấy bảo hiểm xe.\n" +
                    "-         Chịu trách nhiệm pháp lý về nguồn gốc và quyền sở hữu của xe.\n" +
                    "-         Mua bảo hiểm xe và đăng kiểm xe cho các lần kế tiếp trong thời hạn hiệu lực của Hợp đồng.";



                Formatting dieu31ContentFormat = new Formatting();

                dieu31ContentFormat.FontFamily = new Font("Times New Roman");

                dieu31ContentFormat.Size = 12D;

                dieu31ContentFormat.FontColor = Color.Black;
                dieu31ContentFormat.Spacing = 1;


                Paragraph paragraphdieu31Content = doc.InsertParagraph(dieu31Content, false, dieu31ContentFormat);
                #endregion

                #region 10 dieu3.2


                string dieu32 = "3.2. Trách nhiệm, quyền hạn của bên A:";



                Formatting dieu32Format = new Formatting();

                dieu32Format.FontFamily = new Font("Times New Roman");

                dieu32Format.Size = 12D;

                dieu32Format.FontColor = Color.Black;
                dieu32Format.Bold = true;
                dieu32Format.Italic = true;
                dieu32Format.Spacing = 1;

                Paragraph paragraphdieu32 = doc.InsertParagraph(dieu32, false, dieu32Format);
                #endregion

                #region 11 dieu3.2


                string dieu32Content = "-         Thanh toán tiền thuê xe cho Bên B đúng hạn.\n" +
                    "-         Chịu toàn bộ chi phí bảo dưỡng xe theo định kỳ\n" +
                    "-         Chịu toàn bộ chi phí xăng dầu khi sử dụng xe.";



                Formatting dieu32ContentFormat = new Formatting();

                dieu32ContentFormat.FontFamily = new Font("Times New Roman");

                dieu32ContentFormat.Size = 12D;

                dieu32ContentFormat.FontColor = Color.Black;
                dieu32ContentFormat.Spacing = 1;


                Paragraph paragraphdieu32Content = doc.InsertParagraph(dieu32Content, false, dieu32ContentFormat);
                #endregion

                #region 12 dieu4


                string dieu4 = "ĐIỀU 4 : HIỆU LỰC HỢP ĐỒNG:";



                Formatting dieu4Format = new Formatting();

                dieu4Format.FontFamily = new Font("Times New Roman");

                dieu4Format.Size = 12D;

                dieu4Format.FontColor = Color.Black;
                dieu4Format.Bold = true;
                dieu4Format.Spacing = 1;

                Paragraph paragraphdieu4 = doc.InsertParagraph(dieu4, false, dieu4Format);
                #endregion


                #region 13 dieu4


                string dieu4Content = "-         Hợp đồng có giá trị kể từ ngày " + createTime.ToString("d") + " đến hết ngày " + ExpiryDate.ToString("d") + "\n" +
                    "-         Nếu một trong hai Bên, bên nào muốn chấm dứt Hợp đồng trước thời hạn thì phải thông báo cho Bên kia trươc ít nhất 01 tháng.";



                Formatting dieu4ContentFormat = new Formatting();

                dieu4ContentFormat.FontFamily = new Font("Times New Roman");

                dieu4ContentFormat.Size = 12D;

                dieu4ContentFormat.FontColor = Color.Black;

                dieu4ContentFormat.Spacing = 1;

                Paragraph paragraphdieu4Content = doc.InsertParagraph(dieu4Content, false, dieu4ContentFormat);
                #endregion


                #region 14 dieu5


                string dieu5 = "ĐIỀU 5 : ĐIỀU KHOẢN CHUNG\n";



                Formatting dieu5Format = new Formatting();

                dieu5Format.FontFamily = new Font("Times New Roman");

                dieu5Format.Size = 12D;

                dieu5Format.FontColor = Color.Black;
                dieu5Format.Bold = true;
                dieu5Format.Spacing = 1;

                Paragraph paragraphdieu5 = doc.InsertParagraph(dieu5, false, dieu5Format);
                #endregion


                #region 13 dieu5


                string dieu5Content = "-         Trong quá trình thực hiện hợp đồng, nếu có đề nghị điều chỉnh thì phải thông báo cho nhau bằng văn bản để cùng bàn bạc giải quyết.\n" +
                    "-         Hai bên cam kết thi hành đúng các điều khoản của hợp đồng, không bên nào tự ý đơn phương sửa đổi, đình chỉ hoặc hủy bỏ hợp đồng. Mọi sự vi phạm phải được xử lý theo pháp luật. \n" +
                    "-         Hợp đồng này có hiệu lực từ ngày ký và coi như được thanh lý sau khi hai bên thực hiện xong nghĩa vụ của mình và không còn bất kỳ khiếu nại nào.\n" +
                    "Hợp đồng được lập thành 02 (bốn) bản có giá trị pháp lý như nhau, Bên A giữ 01 bản. Bên B giữ 01 bản.";



                Formatting dieu5ContentFormat = new Formatting();

                dieu5ContentFormat.FontFamily = new Font("Times New Roman");

                dieu5ContentFormat.Size = 12D;

                dieu5ContentFormat.FontColor = Color.Black;

                dieu5ContentFormat.Spacing = 1;

                Paragraph paragraphdieu5Content = doc.InsertParagraph(dieu5Content, false, dieu5ContentFormat);
                #endregion

                #region 15 sign


                string sign = "\n\nĐẠI DIỆN BÊN A                  ĐẠI DIỆN BÊN B";



                Formatting signFormat = new Formatting();

                signFormat.FontFamily = new Font("Times New Roman");

                signFormat.Size = 12D;

                signFormat.FontColor = Color.Black;
                signFormat.Bold = true;
                signFormat.Spacing = 1;

                Paragraph paragraphsign = doc.InsertParagraph(sign, false, signFormat);
                paragraphsign.Alignment = Alignment.center;
                #endregion

                doc.Save();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
