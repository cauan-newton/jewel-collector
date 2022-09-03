public class Map 
{
    private int tamanho;
    private Jewel joias;
    private Obstacle obstaculos;
    private Robot robo;

    public Map(int tamanho) {
        this.tamanho = tamanho;
    }

    public void setJoias(Jewel joias) {
        this.joias = joias;
    }

    public void setObstaculos(Obstacle obstaculos) {
        this.obstaculos = obstaculos;
    }

    public void setRobo(Robot robo) {
        this.robo = robo;
    }

    public void imprimir() {
        /* O algoritmo para impressão tem a seguinte lógica:
            Para cada espaço, consultamos todos os elementos do mapa
            para verificar se algum deles ocupa esse espaço
            Se sim, imprimimos e seguimos pro espaço seguinte
            Se não, imprimimos um espaço vazio
            (Sim, esse algoritmo é exaustivo e ineficiente)
        */
        for (int i; i < tamanho; i++) {
            for (int j; j < tamanho; j++) {

                if (joias.buscarPos(i, j)) {
                    switch(joias.buscarPos(i, j).getTipo()) 
                    {
                        case "Red":
                            Console.writeLine("JR  ");
                            break;
                        case "Green":
                            Console.writeLine("JG  ");
                            break;
                        case "Blue":
                            Console.writeLine("JB  ");
                            break;
                    }

                } else if (obstaculos.buscarPos(i, j)) {
                    switch(obstaculos.buscarPos(i, j).getTipo()) 
                    {
                        case "Water":
                            Console.writeLine("##  ");
                            break;
                        case "Tree":
                            Console.writeLine("$$  ");
                            break;
                    }

                } else if (robo.buscarPos(i, j)) {
                    Console.writeLine("ME  ");

                } else {
                    Console.writeLine("--  ");
                }
            }
        }
    }

    public boolean checkPassoValido(String passo) {
        switch (passo)
        {
            case "w":
            if (robo.x == 0)
                return false;
            break;
            case "a":
            if (robo.y == 0)
                return false;
            break;
            case "s":
            if (robo.x == tamanho - 1)
                return false;
            break;
            case "d":
            if (robo.x == tamanho - 1)
                return false;
            break;
        }
        return true;
    }

}