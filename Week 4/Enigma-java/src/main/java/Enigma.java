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
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string

        return "Implement the encrypt method";
    }


    public static String Decrypt(String message, int incrementNumber, List<String> rotors)
    {
        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder m = new StringBuilder(message.toUpperCase());

        // for each rotor, starting with the last one
        for (int i=rotors.size()-1; i>=0; i--)
        {
            for (int j=0; j<m.length(); j++) // for each character in the message
            {
                if (alphabet.indexOf(m.charAt(j)) != -1) // if the character is in the alphabet
                {
                    int position=rotors.get(i).indexOf(m.charAt(j));
                    char translatedCharacter = alphabet.charAt(position);
                    m.setCharAt(j, translatedCharacter);
                }
            }
        }

        return m.toString();
        // John stuff
            // Apply the CAESAR shift
            // Return the decrypted string

    }
}
