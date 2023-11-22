/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

/**
 *
 * @author Freddy
 */
public class Cliente extends Persona {
    @Override
    public String toString() {
        return "Cedula: " + getCedula() + ", Nombre: " + getNombre();
    }
}
