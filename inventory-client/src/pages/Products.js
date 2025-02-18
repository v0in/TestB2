import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';

const Products = () => {
    const [products, setProducts] = useState([]);
    const [newProduct, setNewProduct] = useState({ name: '' });
    const [error, setError] = useState(null);

    // Fetch the list of products
    useEffect(() => {
        axios.get('http://localhost:5094/api/product')
            .then(response => setProducts(response.data))
            .catch(() => setError('Error fetching products'));
    }, []);

    const handleChange = (e) => {
        setNewProduct({ ...newProduct, [e.target.name]: e.target.value });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        axios.post('http://localhost:5094/api/product', newProduct)
            .then(response => {
                setProducts([...products, response.data]);
                setNewProduct({ name: '' }); 
            })
            .catch(() => setError('Error adding product'));
    };

    const handleDelete = (id) => {
        axios.delete(`http://localhost:5094/api/product/${id}`)
            .then(() => setProducts(products.filter(product => product.id !== id)))
            .catch(() => setError('Error deleting product'));
    };

    return (
        <div className="container mt-4">
            <h2 className="text-center mb-4">Products</h2>

            {error && <div className="alert alert-danger text-center">{error}</div>}

            {/* Add Product Form */}
            <div className="card mx-auto mb-4 shadow-sm" style={{ maxWidth: "400px" }}>
                <div className="card-body">
                    <h5 className="card-title text-center">Add New Product</h5>
                    <form onSubmit={handleSubmit}>
                        <div className="mb-3">
                            <label htmlFor="product-name" className="form-label">Product Name:</label>
                            <input
                                type="text"
                                id="product-name"
                                name="name"
                                value={newProduct.name}
                                onChange={handleChange}
                                className="form-control"
                                required
                            />
                        </div>
                        <div className="text-center">
                            <button type="submit" className="btn btn-primary w-100">Add Product</button>
                        </div>
                    </form>
                </div>
            </div>

            {/* Product List */}
            <div className="card mx-auto shadow-sm" style={{ maxWidth: "800px" }}>
                <div className="card-body">
                    <h3 className="text-center">Product List</h3>
                    <table className="table table-bordered table-hover">
                        <thead className="table-dark">
                            <tr>
                                <th scope="col">Product Name</th>
                                <th scope="col" className="text-center">Actions</th>
                            </tr>
                        </thead>
                        <tbody>
                            {products.length === 0 ? (
                                <tr><td colSpan="2" className="text-center">No products found</td></tr>
                            ) : (
                                products.map(product => (
                                    <tr key={product.id}>
                                        <td>{product.name}</td>
                                        <td className="text-center">
                                            <Link to={`/product/edit/${product.id}`} className="btn btn-warning btn-sm me-2">Edit</Link>
                                            <button onClick={() => handleDelete(product.id)} className="btn btn-danger btn-sm">Delete</button>
                                        </td>
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

export default Products;
