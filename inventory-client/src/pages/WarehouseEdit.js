import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams, useNavigate } from 'react-router-dom';

const WarehouseEdit = () => {
    const { id } = useParams();
    const navigate = useNavigate();
    const [warehouse, setWarehouse] = useState({ name: '' });
    const [error, setError] = useState(null);

    useEffect(() => {
        axios.get(`http://localhost:5094/api/warehouse/${id}`)
            .then(response => {
                setWarehouse(response.data);
            })
            .catch(err => {
                setError('Error fetching warehouse');
            });
    }, [id]);

    const handleChange = (e) => {
        setWarehouse({
            ...warehouse,
            [e.target.name]: e.target.value
        });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        axios.put(`http://localhost:5094/api/warehouse/${id}`, warehouse)
            .then(() => {
                navigate('/warehouses');
            })
            .catch(err => {
                setError('Error updating warehouse');
            });
    };

    return (
        <div>
            <h2>Edit Warehouse</h2>
            {error && <div style={{ color: 'red' }}>{error}</div>}
            <form onSubmit={handleSubmit}>
                <div>
                    <label>Warehouse Name:</label>
                    <input
                        type="text"
                        name="name"
                        value={warehouse.name}
                        onChange={handleChange}
                    />
                </div>
                <button type="submit">Save Changes</button>
            </form>
        </div>
    );
};

export default WarehouseEdit;
