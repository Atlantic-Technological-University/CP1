/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.List;

public final class Enigma {

    public static String Encrypt(String message, int incrementNumber,List<String> rotors ){
        // TODO - Implement the Encrypt method
        // Steps in brief
        // 1. Apply the CAESAR shift using the increment number
        //comment



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
            message = newMessage;
            System.out.println(regAl);

            regAl = rotors.get(x);
            EncytpedMessage = newMessage;

            System.out.println(rotor);

            System.out.println(EncytpedMessage);

        }
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string

        return EncytpedMessage;
    }


    public static String Decrypt(String message, int incrementNumber, List<String> rotors)
    {
        // TODO - Implement the Decrypt method
        String DencytpedMessage = "";
        message = message.toUpperCase();
        String newMessage  = "";
        int index = 0;
        String regAl = rotors.get(rotors.size()-1);
        String rotor = "";
        for(int x = 0;x<rotors.size();x++)
        {
            if(x!=2)
            {
                rotor = rotors.get(rotors.size()-(2+x));
            }
            else
            {
                rotor = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
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
            System.out.println(regAl);
            if(x!=2)
            {
            regAl = rotors.get(rotors.size()-(2+x));
            }
            DencytpedMessage = newMessage;
            message = newMessage;

            System.out.println(rotor);

            System.out.println(DencytpedMessage);
        }
        // Steps in brief
        // 1. For each rotor in the list rotors, starting with the last rotor
        //  1.1 Translate the message using the rotor
        // 2. Apply the CAESAR shift
        // 3. Return the decrypted string

<<<<<<< DecrptionBranch
        return DencytpedMessage;
=======
        String DecryptedMessage = "";
        message = message.toUpperCase();
        String newMessage  = "";
        int index = 0;
        String regAl = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        for(int x = 0;x<rotors.size();x--)
        {
            String rotor = rotors.get(x);
            newMessage = "";
            for(int y = 0;y<message.length();y--)
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
            DecryptedMessage = newMessage;
        }


        // This is going to be amazing

        return DecryptedMessage;
>>>>>>> main

    }
}
