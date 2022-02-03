/**
 * 
 */
package csc2a.model;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

import csc2a.designpatterns.GameObjectProduct;
import csc2a.designpatterns.iRenderVisitor;
import javafx.scene.image.Image;

/**
 * @author Murendeni
 *
 */
public class Player extends GameObject implements GameObjectProduct{
	
	public static boolean validate(String line) {
		Pattern linePat = Pattern.compile("\\d*[@]\\d*\\s\\d\\s[M]\\s[A-za-z]*[.][j][p][g]");
		return linePat.matcher(line).matches();
	}

	private double life;
	private char gender;
	
	public Player(int x, int y, double life,char gender,Image playerImage) {
		super(x, y,2,playerImage);
		this.life = life;
		this.gender = gender;
		
	}

	public double getLife() {
		return life;
	}

	public void setLife(double life) {
		this.life = life;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
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
