/**
 * 
 */
package csc2a.model;

import csc2a.designpatterns.GameObjectProduct;
import csc2a.designpatterns.iRenderVisitor;
import javafx.scene.image.Image;

/**
 * @author General
 *
 */
public class Enemy extends GameObject implements GameObjectProduct{
	
	private int Striking_power;
	
	public Enemy(int x, int y, int Striking_power,Image image) {
		super(x,y,3,image);
		this.Striking_power = Striking_power;
	}
	
	public int getStriking_power() {
		return Striking_power;
	}

	public void setStriking_power(int striking_power) {
		Striking_power = striking_power;
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
