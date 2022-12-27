namespace QLKinhDoanhBanLapTop.Classes
{
    internal static class Notification
    {
        public static DialogResult Show(string message, ENotifycationType notifycationType = ENotifycationType.Information)
        {
            return MessageBox.Show(
                message,
                GetNotifycationTitle(notifycationType),
                MessageBoxButtons.OK,
                GetNotifycationIcon(notifycationType)
                );
        }

        public static DialogResult Show(string message,
            MessageBoxButtons messageBoxButtons,
            ENotifycationType notifycationType = ENotifycationType.Information
            )
        {
            return MessageBox.Show(
                message,
                GetNotifycationTitle(notifycationType),
                messageBoxButtons,
                GetNotifycationIcon(notifycationType)
                );
        }

        public static DialogResult Show(Exception? ex)
        {
            return MessageBox.Show(
                ex?.Message ?? "Lỗi không xác định",
            GetNotifycationTitle(ENotifycationType.Error),
                MessageBoxButtons.OK,
                GetNotifycationIcon(ENotifycationType.Error)
                );
        }
        public static DialogResult Show(Exception? ex,
            MessageBoxButtons messageBoxButtons)
        {
            return MessageBox.Show(
                ex?.Message ?? "Lỗi không xác định",
            GetNotifycationTitle(ENotifycationType.Error),
                messageBoxButtons,
                GetNotifycationIcon(ENotifycationType.Error)
                );
        }

        private static string GetNotifycationTitle(
            ENotifycationType notifycationType)
        {
            return notifycationType switch
            {
                ENotifycationType.Error => "Lỗi",
                ENotifycationType.Warning => "Cảnh báo",
                ENotifycationType.Successful => "Thành công",
                _ => "Thông báo"
            };
        }

        private static MessageBoxIcon GetNotifycationIcon(
            ENotifycationType notifycationType)
        {
            return notifycationType switch
            {
                ENotifycationType.Error => MessageBoxIcon.Error,
                ENotifycationType.Warning => MessageBoxIcon.Warning,
                ENotifycationType.Successful => MessageBoxIcon.Information,
                _ => MessageBoxIcon.Information
            };
        }

    }
    enum ENotifycationType
    {
        Error,
        Information,
        Warning,
        Successful
    }

}
