package csc2a.ui;

import javafx.scene.input.KeyCode;
import javafx.scene.layout.StackPane;
import javafx.scene.control.MenuBar;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Random;

import javax.swing.JOptionPane;

import csc2a.designpatterns.GameObjectFactory;
import csc2a.designpatterns.GameObjectProduct;
import csc2a.designpatterns.ProduceGameObjectFactoory;
import csc2a.file.GameFileHandler;
import csc2a.model.GameObject;
import csc2a.model.GameObjectContainer;
import csc2a.model.Player;
import csc2a.model.Tree;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.control.Menu;
import javafx.scene.control.MenuItem;
import javafx.scene.layout.VBox;
import javafx.scene.paint.Color;
import javafx.application.Platform;
import javafx.scene.control.ScrollPane;
import javafx.scene.image.Image;
import javafx.stage.FileChooser;
import javafx.scene.control.Label;
import javafx.scene.layout.BorderPane;
/**
 * 
 * GamePane provides a custom container to manage all game interactions
 * and host the GameCanvas
 * @author <YOUR DETAILS HERE>
 *
 */
public class GamePane extends StackPane{
	
	//Attributes
	private GameCanvas canvas; //You need the canvas so the visitor can draw on it
	private GameObject  player;
	private GameObject  enemy;
	private GameObjectContainer<GameObject> container;
	private Random num;
	
	/**
	 * Default constructor
	 */
	public GamePane() {
		super();
		container = new GameObjectContainer<>();
		//Create the canvas to draw on
		canvas = new GameCanvas();
		num = new Random();
		
		//Bind the width and height so the canvas resizes with window	
		canvas.setWidth(1250);
		canvas.setHeight(650);
		
		/*canvas.widthProperty().bind(this.widthProperty());
		canvas.heightProperty().bind(this.heightProperty());*/
		
		/* TODO: Construct your GamePane as you see fit */
		
		/*player = new Player(50, 50, 5,'f');*/
		//objs.add(player);
		GameObjectFactory objectFactory = null;
		
		GameObjectProduct gameo = null;
		
		objectFactory =new ProduceGameObjectFactoory();
		
		gameo = objectFactory.ProduceTree(150, 150, 50, 50, "tree.jpg");
		
		GameObject tree = (GameObject) gameo;
		
		gameo = objectFactory.ProduceEnemy(350, 250, 2, "enemy1.jpg");
		enemy = (GameObject) gameo;
		
		/*canvas.setItem(player);
		canvas.setItem(tree);*/
		
		File read = new File("./data/objects/objects set 1.txt");
		
		if(read !=null) {
			
			player = GameFileHandler.readObjects(read);
			JOptionPane.showMessageDialog(null,"Yo reader");
		}
		
		container.addGameObject(player);
		container.addGameObject(tree);
		container.addGameObject(enemy);
		
		canvas.setItems(container);
		
		canvas.redrawCanvas();
		
		canvas.redrawCanvas();
		
		MenuBar mb = new MenuBar();
		Menu menu = new Menu("Options");
		mb.getMenus().add(menu);
		
		MenuItem menuIT =  new MenuItem("Instructions");
		MenuItem menuExit =  new MenuItem("Exit the game");
		menu.getItems().addAll(menuIT,menuExit);
		
		menuIT.setOnAction(new EventHandler<ActionEvent>() {

			@Override
			public void handle(ActionEvent arg0) {
				
				
				
				
				File read = new File("./data/instructions/instructions.txt");
				
				if(read !=null) {
					
					JOptionPane.showMessageDialog(null, "Instruction:  \n  " + GameFileHandler.readInstructions(read));
				}
			}
			
		});
		
		menuExit.setOnAction(new EventHandler<ActionEvent>() {

			@Override
			public void handle(ActionEvent arg0) {
				// TODO Auto-generated method stub
				JOptionPane.showMessageDialog(null, "You have quit the game");

				Platform.exit();
			}
			
		});
		
		
		/* TODO: Do you game logic using Event Handlers*/
		//For example
		this.setOnKeyPressed((event) -> {
			moveEnemy();
			
			//JOptionPane.showMessageDialog(null, generate_random_number(1, 10));
			if(event.getCode()==KeyCode.W) {
				
				int x = (int)player.getXLocation();
				int y = (int)player.getYLocation();
				if(y>50)
					if(isValidmove(x,y-50)){
						y=y-50;
						player.setLocation(x, y);
						canvas.setItems(container);
						//((Player) player).setLife(((Player) player).getLife()-0.5);
						//JOptionPane.showMessageDialog(null, ((Player) player).getLife()-(int)((Player) player).getLife());
					}
					else {
						player.setLocation(x, y);
						canvas.setItems(container);
					}
					isGameOver();
					
					canvas.redrawCanvas();
				
				
				
				
			}
			else if(event.getCode()==KeyCode.S) {
				int x = (int)player.getXLocation();
				int y = (int)player.getYLocation();
				if(y<canvas.getHeight()-50) {
					if(isValidmove(x,y+50)){
						
						y=y+50;
						player.setLocation(x, y);
						canvas.setItems(container);
					}
					else {
						player.setLocation(x, y);
						canvas.setItems(container);
					}
				}
				
				isGameOver();
				
				canvas.redrawCanvas();
			}
			else if(event.getCode()==KeyCode.A) {
				int x = (int)player.getXLocation();
				int y = (int)player.getYLocation();
				if(x>0) {
					if(isValidmove(x-50,y)){
						
						x=x-50;
						player.setLocation(x, y);
						canvas.setItems(container);
					}
					else {
						x = (int)player.getXLocation();
						y = (int)player.getYLocation();
						player.setLocation(x, y);
						canvas.setItems(container);
					}
				}
				
				
				isGameOver();
				
				canvas.redrawCanvas();
			}
			else if(event.getCode()==KeyCode.D) {
				int x = (int)player.getXLocation();
				int y = (int)player.getYLocation();
				if(x<canvas.getWidth()-50) {
					if(isValidmove(x+50,y)){
						
						x=x+50;
						player.setLocation(x, y);
						canvas.setItems(container);
					}
					else {
						x = (int)player.getXLocation();
						y = (int)player.getYLocation();
						player.setLocation(x, y);
						canvas.setItems(container);
					}
				}
				
				isGameOver();
				
				canvas.redrawCanvas();
			}
			
			
		}); 
		this.setOnMouseClicked((event) -> {
			
			
		});
		this.setOnMouseMoved((event) -> {
			
		});		
		
		//Add canvas as a child of the Pane
		VBox hbx = new VBox();
		
		hbx.getChildren().add(mb);
		
		this.getChildren().add(canvas);
		
		this.getChildren().add(hbx);
		
		isGameOver();
		
		
		
		/* TODO: Finish setting up your GamePane */
	}
	
	public void isGameOver() {
		if((player.getXLocation()>1150 && player.getXLocation()<1250) && (player.getYLocation()>500 && player.getYLocation()<600)) {
			player.setLocation((int)player.getXLocation(), (int)player.getYLocation());
			canvas.setItems(container);
			
			canvas.redrawCanvas();
			JOptionPane.showMessageDialog(null, "game over  \n  "+"\n Yeah you have escaped");
			Platform.exit();
			
		}
		else if(((Player) player).getLife()==0) {
			Label l1 = new Label("Warnin :  If you come across any threat you are dead");
			VBox vbx = new VBox();
			vbx.getChildren().add(l1);
			BorderPane bp = new BorderPane();
			bp.setBottom(vbx);
			this.getChildren().add(bp);
		}
		else if(((Player) player).getLife()==-1) {
			JOptionPane.showMessageDialog(null, "game over  \n  "+"\n You are dead");
			Platform.exit();
		}
	}
	
	public boolean isValidmove(int x,int y) {
		
		
		for(GameObject o : container) {
			if(x==o.getXLocation() && y == o.getYLocation() && o.getObjnum()==1) {
				Label l1 = new Label("Warnin :  You cannot go on top of the tree ");
				
				VBox vbx = new VBox();
				vbx.getChildren().add(l1);
				BorderPane bp = new BorderPane();
				bp.setBottom(vbx);
				this.getChildren().add(bp);
				return false;
			}
			else if(x==o.getXLocation() && y == o.getYLocation() && o.getObjnum()==3) {
				((Player) player).setLife(((Player) player).getLife()-1);
				
				Label l2 = new Label("Warnin :  If you move to the enmy you will die ");
				VBox vbx = new VBox();
				vbx.getChildren().add(l2);
				BorderPane bp = new BorderPane();
				bp.setBottom(vbx);
				this.getChildren().add(bp);
				return false;
			}
			
			
		}
		return true;
	}
	public void moveEnemy() {
		int tempval=num.nextInt(100);
		if(tempval <= 10) {
			JOptionPane.showMessageDialog(null, "Ndaa");
			
			int xloc = (int)enemy.getXLocation() ;
			int yloc = (int)(enemy.getYLocation());
			
			if(num.nextInt(100)<=35) {
				 xloc = (int)enemy.getXLocation() +50;
				 yloc = (int)(enemy.getYLocation());
			}
			else if(num.nextInt(100)>=51 && num.nextInt(100)<=75) {
				xloc = (int)enemy.getXLocation()-50;
				 yloc = (int)(enemy.getYLocation());
			}else if(num.nextInt(100)>=51 && num.nextInt(100)<=75) {
				xloc = (int)enemy.getXLocation();
				 yloc = (int)(enemy.getYLocation()+50);
			}
			else if(num.nextInt(100)>=26 && num.nextInt(100)<=50){
				xloc = (int)enemy.getXLocation();
				 yloc = (int)(enemy.getYLocation())-50;
			}
			
			
			
			if(IsinGame(xloc, yloc)) {
				enemy.setLocation(xloc,yloc);
				
			}
			//
		}
	}
	
	public boolean IsinGame(int x, int y) {
		if(y>50 && y<canvas.getHeight()-50)
			return true;
		else if( x>0 && x<canvas.getWidth()-50)
			return true;
		
		return false;
	}
	
}
