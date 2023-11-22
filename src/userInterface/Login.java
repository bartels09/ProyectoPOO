/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package userInterface;

import container.Data;
import java.util.Scanner;
import logica.Autenticacion;

/**
 *
 * @author Freddy
 */
public class Login {
    Scanner sc = new Scanner(System.in);
    Data data = new Data();
    
    public void showLogin(){
        System.out.println("*** Bienvendio al Sistema Anabolic Routines ***");
        System.out.println();
        
        int cantIntentos = 0;
        boolean autenticado = false;
           
        
        do{
            System.out.print("Ingrese el nombre de usuario:");
            String usuarioIngresado = sc.nextLine();
            System.out.print("Ingrese su contrasenia:");
            String contraseniaIngresada = sc.nextLine();
            
            Autenticacion aut = new Autenticacion();
            autenticado = aut.autenticacionCorrecta(data.getUsuarios(),
                    usuarioIngresado, contraseniaIngresada);
            
            if(!autenticado){
                System.out.println("** Usuario o clave incorrecta **");
                cantIntentos ++;
            } else{ 
                if(usuarioIngresado.equals("bartels09")){
                    MenuEntrenador me = new MenuEntrenador(data);
                    me.showMenu();
                } else{
                    System.out.println("sss");
                    MenuCliente mc = new MenuCliente();
                    mc.showMenu();
                }
            } 
        } while (!autenticado && cantIntentos < 3 );
    }
}
