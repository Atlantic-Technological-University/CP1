/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.List;

public final class Enigma {

    public static String Encrypt(String message, int incrementNumber,List<String> rotors ){
        // TODO - Implement the Encrypt method
        // Steps in brief
        // 1. Apply the CAESAR shift using the increment number
        // 2. For each rotor in the list rotors
        String EncytpedMessage = "";
        message = message.toUpperCase();
        String newMessage  = "";
        int index = 0;
        String regAl = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        for(int x = 0;x<rotors.size();x++)
        {
            String rotor = rotors.get(x);
            newMessage = "";
            for(int y = 0;y<message.length();y++)
            {
                
                index = regAl.indexOf(message.substring(y,y+1));
                if(index != -1)
                {
                    newMessage = newMessage + rotor.charAt(index);
                }
                else{
                    newMessage = newMessage + " ";
                }
                
            }
            EncytpedMessage = newMessage;
        }
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string

        return EncytpedMessage;
    }


    public static String Decrypt(String message, int incrementNumber, List<String> rotors)
    {
        // TODO - Implement the Decrypt method

        // Steps in brief
        // 1. For each rotor in the list rotors, starting with the last rotor
        //  1.1 Translate the message using the rotor
        // 2. Apply the CAESAR shift
        // 3. Return the decrypted string

        return "Implement the decrypt";

    }
}
