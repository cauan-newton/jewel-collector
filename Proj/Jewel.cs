public class Jewel
{
    private int x, y;
    private String tipo;

    public void setPos(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    public String getTipo() {
        return tipo;
    }
}