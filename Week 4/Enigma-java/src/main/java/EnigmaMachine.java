import java.util.Arrays;
import java.util.List;

public class EnigmaMachine {

    public String rotorDecrypt(String msg, List<String> rotors) {
        final String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String decryptedMsg = "";
        for (int i = rotors.size() - 1; i >= 0; i--) {
            decryptedMsg = "";
            for (char letter : msg.toCharArray()) {
                if (alphabet.indexOf(letter) == -1) {
                    decryptedMsg += letter;
                } else {
                    int indexInRotor = rotors.get(i).indexOf(letter);
                    decryptedMsg += alphabet.charAt(indexInRotor);
                }
            }
            msg = decryptedMsg;
        }
        return decryptedMsg;
    }

    public static void main(String[] args) {
        EnigmaMachine machine = new EnigmaMachine();

        List<String> rotors = Arrays.asList(
            "BDFHJLCPRTXVZNYEIWGAKMUSQO",
            "AJDKSIRUXBLHWTMCQGZNPYFVOE",
            "EKMFLGDQVZNTOWYHXUSPAIBRCJ"
            
        );

        String encryptedMessage = "KFDI";

        String decryptedMessage = machine.rotorDecrypt(encryptedMessage, rotors);

        System.out.println("Decrypted Message: " + decryptedMessage);
    }
}
