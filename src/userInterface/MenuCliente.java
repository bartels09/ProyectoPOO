/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package userInterface;

import java.util.Scanner;

/**
 *
 * @author Freddy
 */
public class MenuCliente {
    Scanner entry = new Scanner(System.in);
    public void showMenu(){
        
        String opcionIngresada;
        System.out.println("*** Menu Cliente ***");
        do{
            System.out.println("");
            System.out.println("");
            System.out.println("Seleccione una opcion");
            System.out.println("");
            System.out.println("1) Ver rutina");
            System.out.println("2) Ingresar pesos utilizados");
            System.out.println("3) Visualizar pesos recomendados");
            opcionIngresada = entry.nextLine();
            
            switch(opcionIngresada){
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    System.out.println("Gracias por su visita");
                    break;
                default:
                    System.out.println("Opcion no valida");
            }
        } while (!opcionIngresada.equals("3"));
        
    }
}
