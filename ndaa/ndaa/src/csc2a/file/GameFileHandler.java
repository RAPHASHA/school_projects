package csc2a.file;

import java.io.File;
import java.util.Scanner;
import java.util.StringTokenizer;

import javax.swing.JOptionPane;

import csc2a.designpatterns.GameObjectFactory;
import csc2a.designpatterns.GameObjectProduct;
import csc2a.designpatterns.ProduceGameObjectFactoory;
import csc2a.model.GameObject;
import csc2a.model.Player;

/**
 * 
 * Class to handle all interactions with files
 * @author <YOUR DETAILS HERE>
 *
 */
public class GameFileHandler {
	/* TODO: Methods to handle text files */
	public static String readInstructions(File fname) {
		String instructions = " ";
		
		Scanner scan = null;
		
		try {
			scan = new Scanner(fname);
			
			while(scan.hasNext()) {
				String line = scan.nextLine()  ;
				instructions =instructions + "\n " + line;
				

			}
		}
		catch(Exception e){
			
		}
		finally {
			if(scan!=null)
				scan.close();
		}
		return instructions;
	}
	
	public static GameObject readObjects(File objsFile) {
		GameObject obj = null;
		
		Scanner scan =null;
		
		try {
			scan = new Scanner(objsFile);
			
			while(scan.hasNext()) {
				String line = scan.nextLine();
				
				if(Player.validate(line)) {
					StringTokenizer strline = new StringTokenizer(line);
					String location = strline.nextToken();
					int life = Integer.parseInt(strline.nextToken());
					String gender = strline.nextToken();
					String imageName = strline.nextToken();
					
					GameObjectFactory objectFactory = null;
					
					GameObjectProduct gameo = null;
					
					objectFactory =new ProduceGameObjectFactoory();
					
					gameo = objectFactory.ProducePlayer(50, 50, life, gender.charAt(0), imageName);
					
					obj = (GameObject) gameo;
				}
				else{
					
				}
			}
		}
		catch(Exception e) {
			e.printStackTrace();
		}
		finally {
			if(scan!=null)
				scan.close();
		}
		
		
		return obj;
		
	}
	/* TODO: Methods to handle binary files */
}
