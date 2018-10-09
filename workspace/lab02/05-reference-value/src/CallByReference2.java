class CallByReference2 {

    void increment(Point3D point) {
        point = new Point3D();
        point.build(11, 12, 13);
        System.out.println("[increment] x=" + point.x + ";y=" + point.y + ";z=" + point.z);
    }

    public static void main(final String[] args) {
        Point3D p1 = new Point3D();
        p1.build(1, 2, 3);
        CallByReference2 cbr2 = new CallByReference2();
        cbr2.increment(p1);
        System.out.println("[main] x=" + p1.x + ";y=" + p1.y + ";z=" + p1.z);
    }
}