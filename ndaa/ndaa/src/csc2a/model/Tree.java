/**
 * 
 */
package csc2a.model;

import csc2a.designpatterns.GameObjectProduct;
import csc2a.designpatterns.iRenderVisitor;
import javafx.scene.image.Image;

/**
 * @author Murendeni
 *
 */
public class Tree extends GameObject implements GameObjectProduct {
	
	private int width;
	private int height;

	public Tree(int x,int y, Image Timage, int width, int height) {
		super(x, y,1,Timage);
		this.width = width;
		this.height = height;
		
	}
	
	
	public int getWidth() {
		return width;
	}



	public void setWidth(int width) {
		this.width = width;
	}



	public int getHeight() {
		return height;
	}



	public void setHeight(int height) {
		this.height = height;
	}



	@Override
	public void accept(iRenderVisitor visitor) {
		visitor.render(this);
	}

	@Override
	public void ispectObject() {
		// TODO Auto-generated method stub
		
	}

}
