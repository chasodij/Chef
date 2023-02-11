namespace chef.BLL.Validators
{
    public static class TextValidator
    {
        public static (bool isValid, string error) Validate(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return (false, "Поле не повинно бути пустим");
            }
            return (true, string.Empty);
        }
    }
}
