namespace SOLID.I.Problem;

internal interface IFoodOrderService {
    void OrderBurguer(int quantity);
    void OrderPizza(int quantity);
    void OrderSalad(int quantity);

}