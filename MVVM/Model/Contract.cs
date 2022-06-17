using project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Pdf;
using GemBox.Pdf.Content;
using MySqlConnector;

namespace project.MVVM.Model
{
    public class Contract
    {
        private int idContract;
        private int idUser;
        private int idOrderEquipment;
        private DateTime dateofCustody;
        private DateTime dateofEnd;
        private float price;
        private string status;

        public List<Product> ProductsList { get; set; }

        public int IdContract { get { return idContract; } set { idContract = value; } }
        public int IdUser { get { return idUser; } set { idUser = value; } }
        public int IdOrderEquipment { get { return idOrderEquipment; } set { idOrderEquipment = value; } }
        public DateTime DateofCustody { get { return dateofCustody; } set { dateofCustody = value; } }
        public DateTime DateofEnd { get { return dateofEnd; } set { dateofEnd = value; } }
        public float Price { get { return price; } set { price = value; } }
        public string Status { get { return status; } set { status = value; } }

        public Contract(int idContract, int idUser, int idOrderEquipment, DateTime dateofCustody, DateTime dateofEnd, float price, string status)
        {
            IdContract = idContract;
            IdUser = idUser;
            IdOrderEquipment = idOrderEquipment;
            DateofCustody = dateofCustody;
            DateofEnd = dateofEnd;
            Price = price;
            Status = status;
        }

        public string DateOfCustody
        {
            get
            {
                return Convert.ToString(DateofCustody.Year) + "." + Convert.ToString(DateofCustody.Month) + "." + Convert.ToString(DateofCustody.Day);
            }
        }
        public string DateOfEnd
        {
            get
            {
                return Convert.ToString(DateofEnd.Year) + "." + Convert.ToString(DateofEnd.Month) + "." + Convert.ToString(DateofEnd.Day);
            }
        }

        public void MakePdfFile()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            using (var document = new PdfDocument())
            {
                var page = document.Pages.Add();

                using (var formattedText = new PdfFormattedText())
                {
                    formattedText.Language = new PdfLanguage("ru-RU");

                    formattedText.Font = new PdfFont("Times New Roman", 14);
                    formattedText.FontWeight = PdfFontWeight.Bold;
                    formattedText.TextAlignment = PdfTextAlignment.Center;
                    formattedText.AppendLine($"Договор № {idContract}");
                    formattedText.AppendLine($"");
                    formattedText.AppendLine($"");
                    formattedText.AppendLine("1. ПРЕДМЕТ ДОГОВОРА");
                    formattedText.FontWeight = PdfFontWeight.Normal;
                    formattedText.TextAlignment = PdfTextAlignment.Justify;
                    formattedText.FontSize = 12;
                    formattedText.AppendLine("1.1. Арендодатель обязуется предоставить Арендатору за плату во временное владение и пользование");
                    formattedText.AppendLine("движимое имущество, находящееся в технически исправном состоянии в количестве и ассортименте,");
                    formattedText.AppendLine("согласно счёта, на указанное в нем время, а Арендатор обязуется уплачивать арендную плату, согласно");
                    formattedText.AppendLine("условиям настоящего договора.");
                    formattedText.Append("1.2. Передача имущества Арендатору осуществляется в пункте проката.");
                    formattedText.AppendLine();
                    formattedText.FontWeight = PdfFontWeight.Bold;
                    formattedText.FontSize = 14;
                    formattedText.TextAlignment = PdfTextAlignment.Center;
                    formattedText.AppendLine();
                    formattedText.AppendLine("2. ПРАВА И ОБЯЗАННОСТИ СТОРОН");
                    formattedText.FontWeight = PdfFontWeight.Normal;
                    formattedText.TextAlignment = PdfTextAlignment.Justify;
                    formattedText.FontSize = 11;
                    formattedText.AppendLine("2.1. В соответствии с настоящим договором Арендатор обязуется:");
                    formattedText.AppendLine("- предоставить Арендодателю документ удостоверяющий его личность и (или) водительское");
                    formattedText.AppendLine("удостоверение и иную информацию, необходимую для выполнения Арендодателем своих обязанностей; ");
                    formattedText.AppendLine("- в оговоренные сроки и в установленном порядке вносить арендную плату за пользование имуществом,");
                    formattedText.AppendLine("в соответствии с условиями настоящего договора, оплачивать иные услуги, оказываемые Арендодателем; ");
                    formattedText.AppendLine("- пользоваться имуществом, предоставленным в прокат в соответствии с его назначением, не");
                    formattedText.AppendLine("закладывать, не сдавать его в субаренду, не производить разборку и ремонт имущества, не передавать");
                    formattedText.AppendLine("свои права и обязанности по данному договору другому лицу: ");
                    formattedText.AppendLine("- ознакомиться с Правилами пользования прокатом, Правилами техники безопасности для лыжников и");
                    formattedText.AppendLine("сноубордистов, Правилами перевозки пассажиров на канатной дороге, Правилами безопасного поведения на");
                    formattedText.AppendLine("горнолыжных трассах, которые размещены в фойе пункта проката(учебно - тренировочном комплексе),");
                    formattedText.AppendLine("на трассах, и выполнять их; ");
                    formattedText.AppendLine("- вернуть предоставленное в прокат имущество в исправном и пригодном для эксплуатации состоянии, не");
                    formattedText.AppendLine("ухудшив его потребительских качеств и внешнего вида;");
                    formattedText.AppendLine("- бережно относиться к предоставленному в прокат имуществу; ");
                    formattedText.AppendLine("- оплатить Арендодателю стоимость имущества, если недостатки арендованного имущества явились");
                    formattedText.AppendLine("следствием нарушения Арендатором правил эксплуатации и содержания имущества; ");
                    formattedText.AppendLine("- оплатить Арендодателю стоимость ремонта, а если имущество не подлежит ремонту - его стоимость при");
                    formattedText.AppendLine("повреждении или порче предоставленного в прокат имущества по вине Арендатора.");
                    formattedText.AppendLine("2.2. Арендодатель обязуется:");
                    formattedText.AppendLine("- выполнить в согласованные сроки и на профессиональном уровне весь комплеке услуг, предусмотренных");
                    formattedText.AppendLine("разделом 1 договора;");
                    formattedText.AppendLine("- приступить к исполнению своих обязанностей по выдаче имущества только после полной оплаты настоящего");
                    formattedText.AppendLine(" договора;");
                    formattedText.AppendLine("- проверить в присутствии Арендатора исправность предоставленного в прокат по настоящему договору");
                    formattedText.AppendLine("- безвозмездно устранить недостатки имущества на месте либо произвести замену имущества другим");
                    formattedText.AppendLine("имущества; имуществом, находящимся в надлежащем состоянии при обнаружении Арендатором недостатков");
                    formattedText.AppendLine("аналогичным предоставленного в прокат имущества, полностью или частично препятствующих пользованию им.");
                    formattedText.AppendLine("2.3. Арендодатель вправе:");
                    formattedText.AppendLine("- досрочно расторгнуть договор в одностороннем порядке (отказаться от исполнения договора), если Арендатор");
                    formattedText.AppendLine("использует имущество не в соответствии с его назначением либо умышленно или по неосторожности ");
                    formattedText.AppendLine("качество и потребительские свойства имущества; ");
                    formattedText.AppendLine("- проверять порядок, режим, другие условия эксплуатации имущества, его местонахождение и требовать для");
                    formattedText.AppendLine("этого предоставления ему необходимой информации.");
                    page.Content.DrawText(formattedText, new PdfPoint(50,70));
                }
                document.Save("Complex scripts.pdf");
            }
        }

        public void MakeKviranciya()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            using (var document = new PdfDocument())
            {
                var page = document.Pages.Add();
                double margin = 10;

                using (var formattedText = new PdfFormattedText())
                {
                    formattedText.Language = new PdfLanguage("ru-RU");

                    formattedText.Font = new PdfFont("Times New Roman", 12);
                    formattedText.FontWeight = PdfFontWeight.Bold;
                    formattedText.TextAlignment = PdfTextAlignment.Left;
                    formattedText.AppendLine($"Договор № {idContract}");
                    formattedText.AppendLine($"");
                    formattedText.FontWeight = PdfFontWeight.Normal;
                    formattedText.TextAlignment = PdfTextAlignment.Justify;
                    formattedText.FontSize = 10;
                    string connStr = "server=194.87.210.23;user=Egor;database=egorBD;password=qazplmwsxokn134;";
                    MySqlConnection con = new MySqlConnection(connStr);
                    con.Open();
                    MySqlCommand com = new MySqlCommand($"SELECT ФИО FROM Пользователь WHERE IDпользователя={idUser}", con);
                    string fio = "";
                    MySqlDataReader reader= com.ExecuteReader();
                    while (reader.Read())
                        fio = Convert.ToString(reader.GetValue(0));
                    formattedText.AppendLine("Клиент: " + fio);
                    formattedText.AppendLine("Дата начала: " + DateofCustody.ToShortDateString());
                    formattedText.AppendLine("Дата конца: " + DateofEnd.ToShortDateString());
                    formattedText.AppendLine("");
                    formattedText.AppendLine("Товары под аренду:");
                    foreach(var item in ProductsList)
                        formattedText.AppendLine(item.Name + " - " + item.Price + " руб/день");
                    formattedText.AppendLine("");
                    formattedText.AppendLine("Итого к оплате: " + price+ " руб");
                    page.Content.DrawText(formattedText,
                    new PdfPoint((page.CropBox.Width - formattedText.MaxTextWidth) / 2,
                        page.CropBox.Top - margin - formattedText.Height));

                }
                document.Save($"knitanciya_№{idContract}.pdf");
                System.Windows.MessageBox.Show("Заберите файл с квитанцией в папке, где установили программу.", "Квитанция!", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
            }
        }
    }
}
