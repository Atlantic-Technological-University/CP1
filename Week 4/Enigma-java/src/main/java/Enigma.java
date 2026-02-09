/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.List;

public final class Enigma {

    static String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static String Encrypt(String message, int incrementNumber,List<String> rotors ){
        // TODO - Implement the Encrypt method
        // Steps in brief
        // 1. Apply the CAESAR shift using the increment number
        // 2. For each rotor in the list rotors
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string

        return "Implement the encrypt method";
    }


    public static String Decrypt(String message, int incrementNumber, List<String> rotors)
    {
        // TODO - Implement the Decrypt method
        // for each rotor, starting with the last one
        StringBuilder m = new StringBuilder(message.toUpperCase());

        for (int i=rotors.size()-1; i>0; i--)
        {
            for (int j=0; j<m.length(); j++)
            {
                if (alphabet.indexOf(m.charAt(j)) != -1) // if the character is in the alphabet
                {
                    char translatedCharacter = alphabet.charAt(...);
                    m.setCharAt(j, '?');
                }
            }
        }

        // John stuff
            // Apply the CAESAR shift
            // Return the decrypted string

        return "Implement the decrypt";

    }
}
