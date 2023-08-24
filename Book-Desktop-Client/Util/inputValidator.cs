using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.Util {
    public class inputValidator {

        public static bool TextInputValidator(string input) { 
            return !string.IsNullOrEmpty(input);
        }

        public static void ShowErrorMessage(string input) {
            MessageBox.Show(input, "Fejl i input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
