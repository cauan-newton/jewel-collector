public class JewelCollector 
{

  public static void Main() {

    Map mapa = new Map(10);

    Jewel[] joias = new Jewel[6];
    joias[0].setPos(1, 9);
    joias[0].setTipo("Red");
    joias[1].setPos(8, 8);
    joias[1].setTipo("Red");
    joias[2].setPos(9, 1);
    joias[2].setTipo("Green");
    joias[3].setPos(7, 6);
    joias[3].setTipo("Green");
    joias[4].setPos(3, 4);
    joias[4].setTipo("Blue");
    joias[5].setPos(2, 1);
    joias[6].setTipo("Blue");
    mapa.setJoias(joias);

    Obstacle[] obstaculos = new Obstacle[12];
    obstaculos[0].setPos(5, 0);
    obstaculos[0].setTipo("Water");
    obstaculos[1].setPos(5, 1);
    obstaculos[1].setTipo("Water");
    obstaculos[2].setPos(5, 2);
    obstaculos[2].setTipo("Water");
    obstaculos[3].setPos(5, 3);
    obstaculos[3].setTipo("Water");
    obstaculos[4].setPos(5, 4);
    obstaculos[4].setTipo("Water");
    obstaculos[5].setPos(5, 5);
    obstaculos[5].setTipo("Water");
    obstaculos[6].setPos(5, 6);
    obstaculos[6].setTipo("Water");
    obstaculos[7].setPos(5, 9);
    obstaculos[7].setTipo("Tree");
    obstaculos[8].setPos(3, 9);
    obstaculos[8].setTipo("Tree");
    obstaculos[9].setPos(8, 3);
    obstaculos[9].setTipo("Tree");
    obstaculos[10].setPos(2, 5);
    obstaculos[10].setTipo("Tree");
    obstaculos[11].setPos(1, 4);
    obstaculos[11].setTipo("Tree");
    mapa.setObstaculos(obstaculos);

    Robot robo = new Robot();
    robo.setPos(0, 0);
    mapa.setRobo(robo);
  
      bool running = true;
  
      do {
          mapa.imprimir();
  
          Console.WriteLine("Enter the command: ");
          string command = Console.ReadLine();
  
          if (command.Equals("quit")) {
              running = false;
          } else if (command.Equals("w")) {
            if (mapa.checkPassoValido("w"))
              robo.mover("w");              
          } else if (command.Equals("a")) {
            if (mapa.checkPassoValido("a"))
              robo.mover("a");              
          } else if (command.Equals("s")) {
            if (mapa.checkPassoValido("s"))
              robo.mover("s");            
          } else if (command.Equals("d")) {
            if (mapa.checkPassoValido("d"))
              robo.mover("d");          
          } else if (command.Equals("g")) {
            robo.pegarJoia();              
          }
          
      } while (running);
  }
  
}