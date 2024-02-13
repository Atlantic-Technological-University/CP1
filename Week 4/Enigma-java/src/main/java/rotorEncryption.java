import java.util.ArrayList;
import java.util.List;

public class rotorEncryption 
{
    

    public static String testRotorEncrypt(String msg, List<String> rotors)
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

    public static void main(String[] args)
    {
        List<String> rotors = new ArrayList<String>();
        String msg = "ABCD, Testing";
        msg = msg.toUpperCase();
        //First Rotor Test
        rotors.add("BDFHJLCPRTXVZNYEIWGAKMUSQO");
        System.out.println("1 Rotors:"+testRotorEncrypt(msg, rotors));
        //Second Rotor Test
        rotors.add("AJDKSIRUXBLHWTMCQGZNPYFVOE");
        System.out.println("2 Rotors:"+testRotorEncrypt(msg, rotors));
        //Third Rotor Test
        rotors.add("EKMFLGDQVZNTOWYHXUSPAIBRCJ"); 
        System.out.println("3 Rotors:"+testRotorEncrypt(msg, rotors));

    }

}
