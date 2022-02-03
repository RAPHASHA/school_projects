package csc2a.designpatterns;

import csc2a.model.Enemy;
import csc2a.model.Player;
import csc2a.model.Tree;

/**
 * 
 * AbstractVisitor interface
 * Used to define all of the render functions for your different GameObjects
 * @author  <YOUR DETAILS HERE>
 *
 */
public interface iRenderVisitor {

	
	/* TODO: render(YourGameObjectA a); method */
	/**
	 * this function will draww a player
	 * 
	 * @param player Player
	 */
	void render(Player player);
	
	/* TODO: render(YourGameObjectB b); method */
	/**
	 * this class will draw a tree
	 * 
	 * @param tree Tree
	 */
	void render(Tree tree);
	// ...
	
	/* TODO: render(YourGameObjectC c); method */
	/**
	 * this function will draw an enemy 
	 * 
	 * @param enemy Enemy
	 */
	void render(Enemy enemy);
}
