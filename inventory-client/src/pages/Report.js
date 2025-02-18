import React, { useState, useEffect } from 'react';
import axios from 'axios';

const Report = () => {
    const [productsNoWarehouse, setProductsNoWarehouse] = useState([]);
    const [productsLowStock, setProductsLowStock] = useState([]);
    const [error, setError] = useState(null);

    useEffect(() => {
        axios.get('http://localhost:5094/api/report/products-no-warehouse')
            .then(response => {
                setProductsNoWarehouse(response.data);
            })
            .catch(() => {
                setError('Error fetching products with no warehouse assigned');
            });

        axios.get('http://localhost:5094/api/report/products-low-stock')
            .then(response => {
                setProductsLowStock(response.data);
            })
            .catch(() => {
                setError('Error fetching products with low stock');
            });
    }, []);

    return (
        <div className="container mt-4">
            <h2 className="text-center mb-4">Product Reports</h2>
            
            {error && <div className="alert alert-danger text-center">{error}</div>}

            {/* Products with No Warehouse Assigned */}
            <div className="card mb-4 shadow-sm">
                <div className="card-body">
                    <h3 className="card-title text-center">Products with No Warehouse Assigned</h3>
                    <table className="table table-bordered table-striped table-hover">
                        <thead className="table-dark">
                            <tr>
                                <th scope="col">Product Name</th>
                            </tr>
                        </thead>
                        <tbody>
                            {productsNoWarehouse.length === 0 ? (
                                <tr><td className="text-center">No products found</td></tr>
                            ) : (
                                productsNoWarehouse.map(product => (
                                    <tr key={product.id}>
                                        <td>{product.name}</td>
                                    </tr>
                                ))
                            )}
                        </tbody>
                    </table>
                </div>
            </div>

            {/* Products with Low Stock */}
            <div className="card mb-4 shadow-sm">
                <div className="card-body">
                    <h3 className="card-title text-center">Products with Stock Less Than 20</h3>
                    <table className="table table-bordered table-striped table-hover">
                        <thead className="table-dark">
                            <tr>
                                <th scope="col">Product Name</th>
                            </tr>
                        </thead>
                        <tbody>
                            {productsLowStock.length === 0 ? (
                                <tr><td className="text-center">No products with low stock found</td></tr>
                            ) : (
                                productsLowStock.map(product => (
                                    <tr key={product.id}>
                                        <td>{product.name}</td>
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

export default Report;
