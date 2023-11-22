/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package userInterface;
import modelo.*;
import logica.*;
import container.*;
import java.util.Scanner;
import modelo.Resultado;

/**
 *
 * @author Freddy
 */
public class MenuEntrenador {
    
    Data data;
    Scanner entry = new Scanner(System.in);
    
    public MenuEntrenador(Data data) {
        this.data = data;
    }
    
    public void showMenu(){
        
        
        String opcionIngresada;
        System.out.println("*** Menu Entrenador ***");
        do{
            System.out.println("");
            System.out.println("");
            System.out.println("Seleccione una opcion");
            System.out.println("");
            System.out.println("1) Ingresar Cliente");
            System.out.println("2) Eliminar Cliente");
            System.out.println("3) Visualizar Clientes");
            System.out.println("4) Crear rutina");
            System.out.println("5) Visualizar rutina");
            System.out.println("6) Salir");
            opcionIngresada = entry.nextLine();
            
            switch(opcionIngresada){
                case "1":
                    agregarCliente();
                    break;
                case "2":
                    eliminarCliente();
                case "3":
                    verClientes();
                    break;
                case "4":
                    agregarEjercicio();
                    break;
                    case "5":
                    break;
                case "6":
                    System.out.println("Gracias por su visita");
                    break;
                default:
                    System.out.println("Opcion no valida");
            }
        } while (!opcionIngresada.equals("6"));
        
    }
    
    
    //Metodos para Cliente
    private void agregarCliente(){
        AdministracionClientes ac = new AdministracionClientes(data);
        Cliente cliente = new Cliente();
        
        System.out.print("Cedula: ");
        cliente.setCedula(entry.nextLine());
        System.out.print("Nombre del cliente: ");
        cliente.setNombre(entry.nextLine());
        
        Resultado respuesta = ac.agregarCliente(cliente);
        
        if (respuesta.getCodigo()== Resultado.EXITO){
            System.out.println("Operacion exitosa.");
            System.out.println(respuesta.getDescripcion());
        }else{
            System.out.println("Operacion fallida");
            System.out.println(respuesta.getDescripcion());
        }
    }
    
    private void eliminarCliente(){
        AdministracionClientes ac = new AdministracionClientes(data);
        
        System.out.print("Cedula: ");
        Resultado respuesta = ac.eliminarCliente(entry.nextLine());
        
        if (respuesta.getCodigo()== Resultado.EXITO){
            System.out.println("Operacion exitosa.");
            System.out.println(respuesta.getDescripcion());
        }else{
            System.out.println("Operacion fallida");
            System.out.println(respuesta.getDescripcion());
        }
    }
    
    private void verClientes(){
        if (data.getClientes().isEmpty()){
            System.out.println("\n*** No hay actores registrados ***\n");
            return;
        }
        
        System.out.println("\n----- Clientes REGISTRADOS -----");
        for (Cliente a : data.getClientes()){
            System.out.println(a.toString()+"\n");
        }
    }
    
    //Metodos para Rutinas
    private void agregarEjercicio(){
        AdministracionEjercicios ej = new AdministracionEjercicios(data);      
        
        System.out.print("Cédula del cliente: ");
        String cedBuscada = entry.nextLine();
        //Buscar el cliente
        for (Cliente a : data.getClientes()){
            if (a.getCedula()!= null && a.getCedula().equals(cedBuscada)){
                //Retornar error
                System.out.println("Registrar rutina al cliente con cedula: "
                        + a.getCedula() + " y nombre: " + a.getNombre());
                //Almacenar el nombre en una variable para agregarla despues 
                //al array de rutinas
                String nombreCliente = a.getNombre();
                System.out.print("Ingrese la cantidad de dias en la rutina: ");
                int diasTotal = entry.nextInt();
                
                //Se genera un for para ingresar los ejercicios por dia
                for (int dia = 1; dia <= diasTotal; dia++ ){
                    System.out.print("Ingrese la cantidad de ejercicios "
                            + "para el dia " + dia + " :");
                    int ejerciciosTotal = entry.nextInt();
                    
                    //Se crea otro for para agregar los ejercicios
                    //Se llama una instancia para agregar cada ejercicio
                    for(int num = 1; num <= ejerciciosTotal; num++){
                        Ejercicio eje = new Ejercicio();
                        
                        entry.nextLine();
                        System.out.print("Ingrese el nombre del ejercicio "
                                + num + " para el dia " + dia +": ");
                        eje.setNombreEjercicio(entry.nextLine());
                        System.out.print("Ingrese las series del ejercicio "
                                + num + " para el dia " + dia + ": ");
                        eje.setSeries(entry.nextInt());
                        System.out.print("Ingrese las reps del ejercicio "
                                + num + " para el dia " + dia + ": ");
                       eje.setReps(entry.nextInt());
                       eje.setDia(dia);
                       eje.setCedula(cedBuscada);
                       eje.setNombre(nombreCliente);
                    }
                }
                        
                
            } else{
                System.out.print("Cliente no encontrado");
            }//Fin de if para registrar rutina
        }
        
        /*System.out.print("Ejercicio: ");
        ejercicio.setCedula(entry.nextLine());
        System.out.print("Nombre del cliente: ");
        ejercicio.setNombre(entry.nextLine());
        
        Resultado respuesta = ej.agregarEjercicio(ejercicio);
        
        if (respuesta.getCodigo()== Resultado.EXITO){
            System.out.println("Operacion exitosa.");
            System.out.println(respuesta.getDescripcion());
        }else{
            System.out.println("Operacion fallida");
            System.out.println(respuesta.getDescripcion());
        }*/
    }
}
