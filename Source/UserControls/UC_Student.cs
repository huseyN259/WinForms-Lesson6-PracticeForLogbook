using Source.Models;

namespace Source.UserControls;

public partial class UC_Student : UserControl
{
    public UC_Student(Student student)
    {
        InitializeComponent();

        lbl_no.Text = student.Number.ToString();

        if (!string.IsNullOrWhiteSpace(student.PictureUrl))
            pBox_avatar.Load(@$".\..\..\..\Resources\{student.PictureUrl}");
        else
            pBox_avatar.Load(@$".\..\..\..\Resources\avatar.png");

        lbl_fullname.Text = student.FullName;
        lbl_lastIn.Text = student.LastIn.ToShortDateString();

        switch (student.Status)
        {
            case ParticipationStatus.Present:
                rBtn_1.Checked = true;
                break;
            case ParticipationStatus.Late:
                rBtn_2.Checked = true;
                break;
            default:
                break;
        }
    }

    private void UC_Student_Load(object sender, EventArgs e)
    {
        cBox_lab.SelectedIndex = 0;
        cBox_classwork.SelectedIndex = 0;
    }
}