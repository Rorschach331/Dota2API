using Dota2API;

namespace Joyce.Dota2API.ConsoleTest {

    /*
        key=E99AF3581DED23A49576EB68DACBC4A4 
        id=1702629895
    */
    class Program {

        private static string _key;
        private static string _accountIdApproved;
        private static string _accountIdSixtyFour;
        private static string _accountIdNotApproved;
        private static string _specificMatchId;

        public static void Initialize() {
            _key =  "E99AF3581DED23A49576EB68DACBC4A4";
            _accountIdApproved = "1115380";
            _accountIdSixtyFour = "76561197961381108";
            _accountIdNotApproved = "1115381";
            _specificMatchId = "1643018373";
        }
        static void Main(string[] args) {

        }


        private static async void GetHeroTest() {
            
        }
    }
}
