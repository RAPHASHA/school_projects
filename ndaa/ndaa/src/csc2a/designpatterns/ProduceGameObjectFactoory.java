/**
 * 
 */
package csc2a.designpatterns;

import java.io.FileInputStream;
import java.io.FileNotFoundException;

import csc2a.model.Enemy;
import csc2a.model.GameObject;
import csc2a.model.Player;
import csc2a.model.Tree;
import javafx.scene.image.Image;

/**
 * @author Murendeni
 *
 */
public class ProduceGameObjectFactoory implements GameObjectFactory{

	@Override
	public GameObjectProduct ProducePlayer(int x, int y, double life, char gender, String Imagename) {
		// TODO Auto-generated method stub
		Image playerImage = Imagemaker(Imagename);
		
		return new Player(x, y, life, gender, playerImage);
	}

	@Override
	public GameObjectProduct ProduceTree(int x, int y, int width,int height,String Imagename) {
		// TODO Auto-generated method stub
		Image Timage  = Imagemaker(Imagename);
		
		return new Tree(x, y, Timage, width, height);
	}

	@Override
	public GameObjectProduct ProduceEnemy(int x, int y, int StrikingPower, String Imagename) {
		// TODO Auto-generated method stub
		Image image = Imagemaker(Imagename);
		
		return new Enemy(x,y,StrikingPower,image);
	}
	
	public static Image Imagemaker(String Imagename) {
		Image image = null;
		try {
			image = new Image(new FileInputStream(Imagename));
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return image;
	}
}
