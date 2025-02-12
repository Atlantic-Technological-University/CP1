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
        // TODO - Implement the Decrypt method

        // Steps in brief
        // 1. For each rotor in the list rotors, starting with the last rotor
        //  1.1 Translate the message using the rotor
        // 2. Apply the CAESAR shift
        // 3. Return the decrypted string

        char[] decryptedMessage = message.toUpperCase().toCharArray();

            for (int i = rotors.size() - 1; i >= 0; i--) {
                String rotor = rotors.get(i);

                for (int j = 0; j < decryptedMessage.length; j++) {
                    char currentChar = decryptedMessage[j];
                    
                    if (currentChar >= 'A' && currentChar <= 'Z') {
                        int index = rotor.indexOf(currentChar);
                        
                        if (index != -1) {
                            decryptedMessage[j] = (char) ('A' + index);
                            }
                    }
                }
            }

            for (int i = 0; i < decryptedMessage.length; i++) {
                char currentChar = decryptedMessage[i];

                if (currentChar != ' ') {
                    int shifted = (currentChar - 'A' - incrementNumber + 26) % 26;
                    decryptedMessage[i] = (char) ('A' + shifted);
                }
            }

        return new String(decryptedMessage);
    }
}
