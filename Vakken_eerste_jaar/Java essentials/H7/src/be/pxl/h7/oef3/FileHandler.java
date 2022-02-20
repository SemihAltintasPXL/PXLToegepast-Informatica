package be.pxl.h7.oef3;

import javax.imageio.ImageIO;
import java.awt.image.BufferedImage;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

/**
 * Don't touch this file unless you know what you're doing. ;)
 */

public class FileHandler {

    public static final Path PATH = Paths.get("files/H7E3.score");

    public static Result readHighscore() {
        if(Files.exists(PATH)) {
            try {
                BufferedReader reader = Files.newBufferedReader(PATH);
                String line = reader.readLine(); // File should only contains 1 line
                reader.close();
                String[] data = line.split("#");
                data[2] = data[2].replace(',','.'); // Avoid NumberFormatException for now
                return new Result(data);
            } catch (IOException e) {
                System.err.println(e.getMessage());
            }
        }
        return null;
    }

    public static void writeHighscore(Result result) {
        if(!Files.exists(PATH)) {
            try {
                Files.createDirectory(Paths.get("files"));
                Files.createFile(PATH);
            } catch (IOException e) {
                System.err.println("Error creating file: " + e.getMessage());
            }
        }

        try {
            BufferedWriter writer = Files.newBufferedWriter(PATH);
            writer.write(result.toFile());
            writer.close();
        } catch (IOException e) {
            System.err.println("Error creating file: " + e.getMessage());
        }

    }
}
