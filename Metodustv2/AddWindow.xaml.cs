using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Metodustv2
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        Секретар_ВіділенняEntities db;
        public AddWindow()
        {
            InitializeComponent();
            db = new Секретар_ВіділенняEntities();
        }

        private void GroupCB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (GroupCB.Items.Count == 0)
            {
                var q =
                    from Group in db.Група
                    select new
                    {
                        Group.Назва_Групи
                    };
                foreach(var it in q)
                {
                    GroupCB.Items.Add(it.Назва_Групи);
                }
            }
        }

        private void Student_GotFocus(object sender, RoutedEventArgs e)
        {
            if (GroupCB.Items.Count != 0 && GroupCB.SelectedItem != null&&Student.Items.Count==0)
            {
                var q =
                    from Stud in db.Студент
                    join Group in db.Група on Stud.ID_Групи equals Group.ID_Групи
                    where Group.Назва_Групи == GroupCB.SelectedItem
                    select new
                    {
                        Stud.Прізвище
                    };
                foreach(var it in q)
                {
                    Student.Items.Add(it.Прізвище);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Відвідування newRec = new Відвідування();
            var q = 
                from Student in db.Студент
                join Group in db.Група on Student.ID_Групи equals Group.ID_Групи
                where Group.Назва_Групи == GroupCB.SelectedItem && Student.Прізвище==this.Student.SelectedItem
                select new 
                {
                    Student.ID_Студента
                };
            int IdOfStudent = 0;
            foreach(var it in q){
                IdOfStudent = it.ID_Студента;
            }
            try
            {
                int max = db.Відвідування.Max(it => it.ID_of_table) + 1;
                newRec.ID_of_table = max;
                newRec.ID_Cтудента = IdOfStudent;
                newRec.Дата_відвідування = DatePick.SelectedDate;
                newRec.Кількість_пропусків = int.Parse(NumOfPasses.Text);
                db.Відвідування.Add(newRec);
                db.SaveChanges();
                MessageBox.Show("Додавання пройшло успішно");
            }
            catch(Exception exc) 
            {
                MessageBox.Show("Сталася помилка  - " + exc.Message);
            }
        }
    }
}
