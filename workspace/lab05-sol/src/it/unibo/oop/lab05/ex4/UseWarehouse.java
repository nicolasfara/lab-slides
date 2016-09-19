package it.unibo.oop.lab05.ex4;

import it.unibo.oop.lab05.ex3.Product;
import it.unibo.oop.lab05.ex3.Warehouse;

/**
 * @author Mirko Viroli
 * @author Danilo Pianini
 *
 */
public final class UseWarehouse {

    private UseWarehouse() {
    }

    /**
     * @param args
     *            unused
     */
    public static void main(final String[] args) {

        /*
         * Modify the previous exercise in such a way that allProducts() returns
         * the products in order. Favor solutions that reuse existing code.
         */

        final Product p1 = new ComparableProduct("Apple", 100);
        final Product p2 = new ComparableProduct("Banana", 30);
        final Product p3 = new ComparableProduct("Watermelon", 10);

        final Warehouse w = new OrderedWarehouse();
        w.addProduct(p3);
        w.addProduct(p1);
        w.addProduct(p2);

        System.out.println(w.allNames());
        System.out.println(w.allProducts());

    }

}