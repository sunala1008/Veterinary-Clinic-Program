using System.Drawing;
using System.Windows.Forms;

namespace Veterinary_Clinic.Library.Helpers
{
    public static class FormHelper
    {
        public static bool IsDeleteOrNot()
        {
            return MessageBox.Show("삭제하시겠습니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }

        public static void MoveToCenter(this Form form) // 확장 메서드
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - form.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - form.Size.Height / 2
                );
        }
    }
}
