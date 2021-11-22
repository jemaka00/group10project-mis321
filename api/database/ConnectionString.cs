namespace api.database
{
    public class ConnectionString
    {
        public string cs {get; set;}
        public ConnectionString(){
            string server = "yjo6uubt3u5c16az.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "ajj36ctvh1u5fknw";
            string port = "3306";
            string userName = "os6qbn2peri34o4a";
            string password = "z5pwv1vs7wrvxn83";

            cs = $@"server={server};user={userName};database={database};port={port};password={password}";
        }
    }
}