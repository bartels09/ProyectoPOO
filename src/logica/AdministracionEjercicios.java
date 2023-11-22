/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package logica;

import container.Data;
import modelo.Cliente;
import modelo.Ejercicio;
import modelo.Resultado;

/**
 *
 * @author Freddy
 */
public class AdministracionEjercicios {
    private Data data;
    
    public AdministracionEjercicios(Data dataProveniente){
        this.data = dataProveniente;
    }
    
    //Metodo para almacenar ejercicios
    public void ingresarEjercicios(Ejercicio ejercicio){
        data.getEjercicios().add(ejercicio);
    }
}
   
