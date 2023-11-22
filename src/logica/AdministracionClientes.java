/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package logica;
import modelo.Cliente;
import modelo.Resultado;
import container.Data;
/**
 *
 * @author Freddy
 */
public class AdministracionClientes {
    private Data data;
    
    public AdministracionClientes(Data dataProveniente){
        this.data = dataProveniente;
    }
    
    public Resultado agregarCliente(Cliente clienteAAgregar){
        for (Cliente a : data.getClientes()){
            if (a.getCedula()!= null && a.getCedula().equals(clienteAAgregar.getCedula())){
                //Retornar error
                return new Resultado(1, "Ya existe un actor "
                        + "con el id "+clienteAAgregar.getCedula());
            }
        }
        
        data.getClientes().add(clienteAAgregar);
        
        return new Resultado(Resultado.EXITO, "Actor registrado");
    }
    
    public Resultado eliminarCliente(String clienteAEliminar){
        for (Cliente a : data.getClientes()){
            if (a.getCedula().equals(clienteAEliminar)){
                data.getClientes().remove(a);
                return new Resultado(Resultado.EXITO, 
                        "Actor eliminado exitosamente.");
            }
        }
        
        //Retornar error, actor no encontrado.
        return new Resultado(2, "Actor con cedula "+clienteAEliminar+
                " no encontrado");
    }
}
