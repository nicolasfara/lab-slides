package it.unibo.oop.lab.exception02;

/**
 * Models a generic bank account.
 * 
 */
public interface BankAccount {

    /**
     * @param usrID
     *            id of the user requesting this operation
     * @param amount
     *            amount to be withdrawn
     */
    void withdraw(final int usrID, final double amount);

    /**
     * 
     * @param usrID
     *            id of the user requesting this operation
     * @param amount
     *            amount to be credited
     */
    void deposit(int usrID, double amount);

    /**
     * 
     * @param usrID
     *            id of the user requesting this opera
     * @param amount
     *            amount to be deposited via ATM
     */
    void depositFromATM(int usrID, double amount);

    /**
     * 
     * @param usrID
     *            id of the user requesting this opera
     * @param amount
     *            amount to be withdrawn via AT
     */
    void withdrawFromATM(int usrID, double amount);

    /**
     * 
     * @return The current balance
     */
    double getBalance();

    /**
     * 
     * @return The total number of transaction for the account
     */
    int getNTransactions();

}