package csc2a.designpatterns;

import csc2a.model.GameObject;
import javafx.scene.image.Image;

public abstract interface GameObjectFactory {
	public abstract GameObjectProduct ProducePlayer(int x, int y, double life,char gender,String playerImage);
	public abstract GameObjectProduct ProduceTree(int x, int y, int width,int height,String playerImage);
	public abstract GameObjectProduct ProduceEnemy(int x, int y, int StrikingPower,String playerImage);
}
