package csc2a.designpatterns;

import java.awt.image.BufferedImage;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.InputStream;

import javax.imageio.ImageIO;

import csc2a.model.Enemy;
import csc2a.model.Player;
import csc2a.model.Tree;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
import javafx.scene.image.Image;  

/**
 * ConcreteVisitor class
 * Used to visit each GameObject and render them onto the GameCanvas
 * @author  <YOUR DETAILS HERE>
 *
 */
public class RenderGameObjectVisitor implements iRenderVisitor{
	
	//Attributes
	GraphicsContext gc = null;
	
	/**
	 * Mutator for the GraphicsContext from the GameCanvas
	 * Used to set gc so the Visitor can draw things on the Canvas
	 * @param gc the GraphicsContext from the GameCanvas
	 */
	public void setGraphicsContext(GraphicsContext gc) {
		this.gc = gc;
	}

	@Override
	public void render(Player player) {
		double x = player.getXLocation();
		double y = player.getYLocation();
		
		//gc.setFill(Color.RED);
		
		String imagepath1  ="life.jpg";
		String imagepath2  ="life half.jpg";
		
		Image image1 = null;
		Image image2 = null;
		
		try {
			image1 = new Image(new FileInputStream(imagepath1));
			image2 = new Image(new FileInputStream(imagepath2));
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		gc.drawImage(((Player) player).getImage(), x, y, 50, 50);
		
		
		
		if(player.getLife()-((int)(player.getLife()))==.5) {
			
			int lastlifepos = 0;
			for(int r=0;r<player.getLife()-2;r++) {
				gc.strokeText("L i v e s  l e f t : ", 15,25);
				gc.drawImage(image1,10*(r+1)+5, 35, 10, 10);
				lastlifepos = r;
			}
			
			gc.drawImage(image2,10*(lastlifepos+1)+5, 35, 10, 10);
			
		}
		else
		{
			
			for(int r=0;r<player.getLife();r++) {
				gc.strokeText("L i v e s  l e f t : ", 15,25);
				gc.drawImage(image1,10*(r+1)+5, 35, 10, 10);
			}
		}
	}

	@Override
	public void render(Tree tree) {
		// TODO Auto-generated method stub
		double x = tree.getXLocation();
		double y = tree.getYLocation();
		gc.drawImage(tree.getImage(),x, y,tree.getWidth(),tree.getHeight());
	}
	
	
	/* TODO: render(YourGameObjectA a){} method */
	@Override
	public void render(Enemy enemy) {
		// TODO Auto-generated method stub
		double x = enemy.getXLocation();
		double y = enemy.getYLocation();
		
		gc.drawImage(enemy.getImage(),x, y,50,50);
	}
	
	/* TODO: render(YourGameObjectB b){} method */
	
	// ...
	
	/* TODO: render(YourGameObjectC m){} method */
	

}
