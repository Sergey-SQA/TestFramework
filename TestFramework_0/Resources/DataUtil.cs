namespace TestFramework
{
    public class DataUtil
    {
        public static string[][] SearchFieldDataSource()//must be static
        {

            string[][] data = {                                 
                new string[]{"", "//*[contains(text(), 'Please enter a search')]"},                                 
                new string[]{"Blouse", "//*[@title='Blouse'][@itemprop='image']"},                                 
                new string[]{"Polo", "//*[contains(text(), 'No results')]"}
                             };
            return data;
        }
        public static string[][] EmailFieldDataSource()//must be static
        {
            string[][] data = {               
                new string[]{ "plainaddress", "//*[contains(text(),'Invalid email address.')]"},               
                new string[]{ "#@%^%#$@#$@#.com", "//*[contains(text(),'Invalid email address.')]"},
                new string[]{ "email@-example.com", "//*[contains(text(),'Invalid email address.')]" }
                             };
            return data;
        }
        public static string[][] PasswordFieldDataSource()//must be static
        {
            string[][] data = {
                new string[]{ "1", "//*[contains(text(),'Invalid password.')]"},               
                new string[]{ "12", "//*[contains(text(),'Invalid password.')]"},                
                new string[]{ "123", "//*[contains(text(),'Invalid password.')]"},                
                new string[]{ "1234", "//*[contains(text(),'Invalid password.')]"}
                             };
            return data;
        }
    }
}
