import java.util.List;

public class Rotor 
{

    public String rotorEncrypt(String msg, List<String> rotors)
    {
        final String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String encryptedMsg = "";
        for (int i = 0; i < rotors.size(); i++)
        {
            //Swaps/resets variables after the first loop
            if(i > 0)
            {
                msg = encryptedMsg;
                encryptedMsg = "";
            }

            for(char letter: msg.toCharArray())
            {
                if(alphabet.indexOf(letter) == -1)
                {

                    encryptedMsg += letter;

                }
                else{

                    //Gets the index of where the msg character is on the alphabet and adds its rotor counterpart to encryptedMsg
                    encryptedMsg += rotors.get(i).charAt(alphabet.indexOf(letter));

                }
                
            }

        }
        
        return encryptedMsg;
    }

    public String rotorDecrypt(String msg, List<String> rotors)
    {
        return "Add Method when reviewed";
    }
    
}