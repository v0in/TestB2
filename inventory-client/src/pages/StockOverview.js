import React, { useState, useEffect } from 'react';
import axios from 'axios';

const StockOverview = () => {
    const [stockRecords, setStockRecords] = useState([]);
    const [products, setProducts] = useState([]);
    const [warehouses, setWarehouses] = useState([]);
    const [newStock, setNewStock] = useState({ productId: '', warehouseId: '', quantity: '' });
    const [error, setError] = useState(null);
    const [searchQuery, setSearchQuery] = useState('');
    const [selectedWarehouse, setSelectedWarehouse] = useState('');

    useEffect(() => {
        axios.get('http://localhost:5094/api/stockrecord')
            .then(response => setStockRecords(response.data))
            .catch(() => setError('Error fetching stock records'));

        axios.get('http://localhost:5094/api/product')
            .then(response => setProducts(response.data))
            .catch(() => setError('Error fetching products'));

        axios.get('http://localhost:5094/api/warehouse')
            .then(response => setWarehouses(response.data))
            .catch(() => setError('Error fetching warehouses'));
    }, []);

    const handleChange = (e) => {
        setNewStock({ ...newStock, [e.target.name]: e.target.value });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        const { productId, warehouseId, quantity } = newStock;

        if (!productId || !warehouseId || !quantity) {
            setError('Please fill in all fields');
            return;
        }

        axios.post('http://localhost:5094/api/stockrecord', { productId, warehouseId, quantity })
            .then(() => {
                axios.get('http://localhost:5094/api/stockrecord')
                    .then(response => setStockRecords(response.data))
                    .catch(() => setError('Error fetching stock records after adding new stock'));
                setNewStock({ productId: '', warehouseId: '', quantity: '' });
                setError(null);
            })
            .catch(() => setError('Error adding stock record'));
    };

    const filteredStockRecords = stockRecords.filter(stock => {
        const matchesSearch = stock.product?.name.toLowerCase().includes(searchQuery.toLowerCase());
        const matchesWarehouse = selectedWarehouse ? stock.warehouse?.id === parseInt(selectedWarehouse) : true;
        return matchesSearch && matchesWarehouse;
    });

    return (
        <div className="container mt-4">
            <h2 className="text-center mb-4">Stock Overview</h2>
            {error && <div className="alert alert-danger text-center">{error}</div>}

            {/* add fofmr */}
            <div className="card mx-auto mb-4 shadow-sm" style={{ maxWidth: "500px" }}>
                <div className="card-body">
                    <h5 className="card-title text-center">Add New Stock</h5>
                    <form onSubmit={handleSubmit}>
                        <div className="mb-3">
                            <label htmlFor="productId" className="form-label">Product:</label>
                            <select id="productId" name="productId" value={newStock.productId} onChange={handleChange} className="form-select" required>
                                <option value="">Select a product</option>
                                {products.map(product => (
                                    <option key={product.id} value={product.id}>{product.name}</option>
                                ))}
                            </select>
                        </div>

                        <div className="mb-3">
                            <label htmlFor="warehouseId" className="form-label">Warehouse:</label>
                            <select id="warehouseId" name="warehouseId" value={newStock.warehouseId} onChange={handleChange} className="form-select" required>
                                <option value="">Select a warehouse</option>
                                {warehouses.map(warehouse => (
                                    <option key={warehouse.id} value={warehouse.id}>{warehouse.name}</option>
                                ))}
                            </select>
                        </div>

                        <div className="mb-3">
                            <label htmlFor="quantity" className="form-label">Quantity:</label>
                            <input type="number" id="quantity" name="quantity" value={newStock.quantity} onChange={handleChange} className="form-control" required />
                        </div>

                        <div className="text-center">
                            <button type="submit" className="btn btn-primary w-100">Add Stock</button>
                        </div>
                    </form>
                </div>
            </div>

            {/*  search */}
            <div className="d-flex justify-content-center mb-3">
                <input
                    type="text"
                    placeholder="Search by product name..."
                    className="form-control w-50 me-2"
                    value={searchQuery}
                    onChange={(e) => setSearchQuery(e.target.value)}
                />
                <select className="form-select w-25" value={selectedWarehouse} onChange={(e) => setSelectedWarehouse(e.target.value)}>
                    <option value="">All Warehouses</option>
                    {warehouses.map(warehouse => (
                        <option key={warehouse.id} value={warehouse.id}>{warehouse.name}</option>
                    ))}
                </select>
            </div>


            <h3 className="text-center mb-4">Stock Records</h3>
            <div className="card mx-auto shadow-sm" style={{ maxWidth: "1000px" }}>
                <div className="card-body">
                    <table className="table table-bordered table-striped table-hover">
                        <thead className="table-dark">
                            <tr>
                                <th scope="col">Product</th>
                                <th scope="col">Warehouse</th>
                                <th scope="col">Quantity</th>
                            </tr>
                        </thead>
                        <tbody>
                            {filteredStockRecords.length === 0 ? (
                                <tr><td colSpan="3" className="text-center">No matching stock records found</td></tr>
                            ) : (
                                filteredStockRecords.map((stock, index) => (
                                    <tr key={index}>
                                        <td>{stock.product ? stock.product.name : 'Loading...'}</td>
                                        <td>{stock.warehouse ? stock.warehouse.name : 'Loading...'}</td>
                                        <td>{stock.quantity}</td>
                                    </tr>
                                ))
                            )}
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    );
};

export default StockOverview;
