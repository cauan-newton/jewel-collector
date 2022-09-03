public class Map 
{
    private int tamanho;
    private Jewel[] joias;
    private Obstacle[] obstaculos;
    private Robot robo;

    public Map(int tamanho) {
        this.tamanho = tamanho;
    }

    public void setJoias(Jewel[] joias) {
        this.joias = joias;
    }

    public void setObstaculos(Obstacle[] obstaculos) {
        this.obstaculos = obstaculos;
    }

    public void setRobo(Robot robo) {
        this.robo = robo;
    }

    private Jewel acharJoia(int x, int y) {
        for (int i = 0; i < joias.GetLength(0); i++) {
            if (joias[i].getX() == x && joias[i].getY() == y)
                return joias[i];
        }

        return null;
    }

    private Obstacle acharObstaculo(int x, int y) {
        for (int i = 0; i < obstaculos.GetLength(0); i++) {
            if (obstaculos[i].getX() == x && obstaculos[i].getY() == y)
                return obstaculos[i];
        }

        return null;
    }
    private Robot acharRobo(int x, int y) {
        if (robo.getX() == x && robo.getY() == y) {
            return robo;
        } else {
            return null;
        }
    }

    public void imprimir() {
        /* O algoritmo para impressão tem a seguinte lógica:
            Para cada espaço, consultamos todos os elementos do mapa
            para verificar se algum deles ocupa esse espaço
            Se sim, imprimimos e seguimos pro espaço seguinte
            Se não, imprimimos um espaço vazio
            (Sim, esse algoritmo é exaustivo e ineficiente)
        */
        for (int i = 0; i < tamanho; i++) {
            for (int j = 0; j < tamanho; j++) {

                if (acharJoia(i, j) != null) {
                    switch(acharJoia(i, j).getTipo()) 
                    {
                        case "Red":
                            Console.Write("JR  ");
                            break;
                        case "Green":
                            Console.Write("JG  ");
                            break;
                        case "Blue":
                            Console.Write("JB  ");
                            break;
                    }

                } else if (acharObstaculo(i, j) != null) {
                    switch(acharObstaculo(i, j).getTipo()) 
                    {
                        case "Water":
                            Console.Write("##  ");
                            break;
                        case "Tree":
                            Console.Write("$$  ");
                            break;
                    }

                } else if (acharRobo(i, j) != null) {
                    Console.Write("ME  ");

                } else {
                    Console.Write("--  ");
                }
            }
            Console.WriteLine();
        }
    }

    public Boolean checkPassoValido(String passo) {
        switch (passo)
        {
            case "w":
            if (robo.getX() == 0)
                return false;
            break;
            case "a":
            if (robo.getY() == 0)
                return false;
            break;
            case "s":
            if (robo.getX() == tamanho - 1)
                return false;
            break;
            case "d":
            if (robo.getY() == tamanho - 1)
                return false;
            break;
        }
        return true;
    }

}