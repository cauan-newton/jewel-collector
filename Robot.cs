public class Robot
{
    private int x, y;
    private Jewel[] bag;

    public void setPos(int x, y) {
        this.x = x;
        this.y = y;
    }

    public void mover(String direction) {
        switch (direction) 
        {
            case "w":
                x--;
                break;
            case "a":
                y--;
                break;
            case "s":
                x++;
                break;
            case "d":
                y++;
                break;
        }
    }

    public void pegarJoia() {
        
    }
}