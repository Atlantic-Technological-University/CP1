/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.List;

public final class Enigma {

    private Enigma()
    {

    }

    public static String encrypt(String message, int incrementNumber,List<String> rotors ){
        // TODO - Implement the Encrypt method
        // Steps in brief
        // 1. Apply the CAESAR shift using the increment number
        // 2. For each rotor in the list rotors
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string

        return "Implement the encrypt method";
    }


    public static String decrypt(String message, int incrementNumber, List<String> rotors)
    {
        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder m = new StringBuilder(message.toUpperCase());

        // reverse rotors
        for (int i=rotors.size()-1; i>=0; i--)    // for each rotor, starting with the last one
        {
            for (int j=0; j<m.length(); j++) // for each character in the message
            {
                char currentChar = m.charAt(j);
                if (alphabet.indexOf(currentChar) != -1) // if the character is in the alphabet
                {
                    int position=rotors.get(i).indexOf(currentChar);
                    char translatedCharacter = alphabet.charAt(position);
                    m.setCharAt(j, translatedCharacter);
                }
            }
        }

        // reverse caesar shift
        for (int i=0; i<m.length(); i++)
        {
            char currentChar = m.charAt(i);
            if (alphabet.indexOf(currentChar) != -1)
            {
                int position = alphabet.indexOf(currentChar);
                int shiftedPosition=position-incrementNumber-i;

                // wrap back to start of alphabet
                if (shiftedPosition<0)
                    shiftedPosition+=25;
                
                char replacementChar = alphabet.charAt(shiftedPosition);
                m.setCharAt(i, replacementChar);
            }
        }

        return m.toString();

    }
}
