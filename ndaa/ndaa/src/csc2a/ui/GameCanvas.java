package csc2a.ui;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.ArrayList;

import javax.swing.JOptionPane;

import csc2a.designpatterns.RenderGameObjectVisitor;
import csc2a.model.GameObject;
import csc2a.model.GameObjectContainer;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.image.Image;
import javafx.scene.paint.Color;
/**
 * 
 * Canvas used to render all of your GameObjects using the Visitor
 * This is the Client in the Visitor Design Pattern
 * @author  <YOUR DETAILS HERE>
 *
 */
public class GameCanvas extends Canvas{
	
	//Attributes
	RenderGameObjectVisitor visitor = new RenderGameObjectVisitor();
	/* TODO: Store all of your GameObjects (Using GameObjectContainers) here */
	GameObjectContainer<GameObject> container;
	
	/**
	 * Default Constructor
	 */
	public GameCanvas() {
		container = new GameObjectContainer<>();
	}
	
	/* TODO: Set your GameObjects and redrawCanvas() */
	public void setItems(GameObjectContainer<GameObject> container) {
		this.container = container;
		redrawCanvas();
	}
	
	/**
	 * Method used to redraw the canvas whenever called
	 */
	public void redrawCanvas(){
		/* TODO: Get GraphicsContext */
		
		GraphicsContext gc = getGraphicsContext2D();
		
		String imagepath  ="images.jpg";
		String imagepath1  ="BBPrdhz.jpg";
		Image image = null;
		Image image1 = null;
		try {
			image = new Image(new FileInputStream(imagepath));
			image1= new Image(new FileInputStream(imagepath1));
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		gc.drawImage(image, 0, 30, getWidth(), getHeight());
		
		gc.drawImage(image1, 1200, 550, 50, 50);
		//gc.strokeText("End", 1200, 550);
		/* TODO: Set Visitor's GraphicsContext */
		visitor.setGraphicsContext(gc);
		
		/* TODO: Iterate through ALL GameObjects (Using GameObjectContainers) */
		for(GameObject o : container) {
			o.accept(visitor);
		}
			/* TODO: Get EACH GameObject to accept() the Visitor */
	}	
}
