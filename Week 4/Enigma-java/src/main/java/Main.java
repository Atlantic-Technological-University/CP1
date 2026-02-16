import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args)
    {
        // Obtain a reference to the console

        System.out.println("Hello world");

        // List of rotors to map characters. Spaces in the rotor strings should be ignored.
        List<String> rotors = new ArrayList<>();
        rotors.add("BDFHJLCPRTXVZNYEIWGAKMUSQO");
        rotors.add("AJDKSIRUXBLHWTMCQGZNPYFVOE");
        rotors.add("EKMFLGDQVZNTOWYHXUSPAIBRCJ");

        String startMessage = "Hello world";
        String encryptedMessage = Enigma.encrypt(startMessage, 4, rotors);
        System.out.println("The encrypted message is: " + encryptedMessage);

        String decryptedMessage = Enigma.decrypt(encryptedMessage, 4, rotors);
        System.out.println("The decrypted message is: " + decryptedMessage);
    }
}
