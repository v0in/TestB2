import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams, useNavigate } from 'react-router-dom';

const ProductEdit = () => {
    const { id } = useParams();
    const navigate = useNavigate(); 
    const [product, setProduct] = useState({ name: '' });
    const [error, setError] = useState(null);

    useEffect(() => {
        axios.get(`http://localhost:5094/api/product/${id}`)
            .then(response => {
                setProduct(response.data);
            })
            .catch(err => {
                setError('Error fetching product');
            });
    }, [id]);

    const handleChange = (e) => {
        setProduct({
            ...product,
            [e.target.name]: e.target.value
        });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        axios.put(`http://localhost:5094/api/product/${id}`, product)
            .then(() => {
                navigate('/products'); 
            })
            .catch(err => {
                setError('Error updating product');
            });
    };

    return (
        <div>
            <h2>Edit Product</h2>
            {error && <div style={{ color: 'red' }}>{error}</div>}
            <form onSubmit={handleSubmit}>
                <div>
                    <label>Product Name:</label>
                    <input
                        type="text"
                        name="name"
                        value={product.name}
                        onChange={handleChange}
                    />
                </div>
                <button type="submit">Save Changes</button>
            </form>
        </div>
    );
};

export default ProductEdit;
