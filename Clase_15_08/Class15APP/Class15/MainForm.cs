using Class15.CustomEvents;

namespace Class15
{
    public partial class MainForm : Form
    {
        private systemErrorHandLer _errorHandLer;
        private FileDownloadedNotificationHandler _fileNotificationHandler;
        public MainForm()
        {
            InitializeComponent();
            _errorHandLer = new systemErrorHandLer();
            _errorHandLer.systemErrorEventNotification += OnSystemErrorEventNotification;
        }

        public void OnSystemErrorEventNotification(object sender, string message)
        {
            MessageBox.Show($"Error: {message}",
                "Error desde Evento",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = 16;
                int secondNumber = 0;

                decimal result = firstNumber / secondNumber;
            }
            catch (Exception ex)
            {
                _errorHandLer.SendSystemErrorNotification(ex.Message);
            }   

        }
    }
}
