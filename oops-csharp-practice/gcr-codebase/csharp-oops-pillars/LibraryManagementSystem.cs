using System;
interface IReservable
{
    void ReserveItem(); // Method to reserve an item
    double CheckAvailability(); // Method to check availability
}
abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;


}