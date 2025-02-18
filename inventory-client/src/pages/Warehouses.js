import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';

const Warehouses = () => {
    const [warehouses, setWarehouses] = useState([]);
    const [newWarehouse, setNewWarehouse] = useState({ name: '' });
    const [error, setError] = useState(null);

    // Fetch the list of warehouses
    useEffect(() => {
        axios.get('http://localhost:5094/api/warehouse')
            .then(response => setWarehouses(response.data))
            .catch(() => setError('Error fetching warehouses'));
    }, []);

    const handleChange = (e) => {
        setNewWarehouse({ ...newWarehouse, [e.target.name]: e.target.value });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        axios.post('http://localhost:5094/api/warehouse', newWarehouse)
            .then(response => {
                setWarehouses([...warehouses, response.data]);
                setNewWarehouse({ name: '' }); 
            })
            .catch(() => setError('Error adding warehouse'));
    };

    const handleDelete = (id) => {
        axios.delete(`http://localhost:5094/api/warehouse/${id}`)
            .then(() => setWarehouses(warehouses.filter(warehouse => warehouse.id !== id)))
            .catch(() => setError('Error deleting warehouse'));
    };

    return (
        <div className="container mt-4">
            <h2 className="text-center mb-4">Warehouses</h2>

            {error && <div className="alert alert-danger text-center">{error}</div>}

            {/* Add Warehouse Form */}
            <div className="card mx-auto mb-4 shadow-sm" style={{ maxWidth: "400px" }}>
                <div className="card-body">
                    <h5 className="card-title text-center">Add New Warehouse</h5>
                    <form onSubmit={handleSubmit}>
                        <div className="mb-3">
                            <label htmlFor="warehouse-name" className="form-label">Warehouse Name:</label>
                            <input
                                type="text"
                                id="warehouse-name"
                                name="name"
                                value={newWarehouse.name}
                                onChange={handleChange}
                                className="form-control"
                                required
                            />
                        </div>
                        <div className="text-center">
                            <button type="submit" className="btn btn-primary w-100">Add Warehouse</button>
                        </div>
                    </form>
                </div>
            </div>

            {/* Warehouse List */}
            <div className="card mx-auto shadow-sm" style={{ maxWidth: "800px" }}>
                <div className="card-body">
                    <h3 className="text-center">Warehouse List</h3>
                    <table className="table table-bordered table-hover">
                        <thead className="table-dark">
                            <tr>
                                <th scope="col">Warehouse Name</th>
                                <th scope="col" className="text-center">Actions</th>
                            </tr>
                        </thead>
                        <tbody>
                            {warehouses.length === 0 ? (
                                <tr><td colSpan="2" className="text-center">No warehouses found</td></tr>
                            ) : (
                                warehouses.map(warehouse => (
                                    <tr key={warehouse.id}>
                                        <td>{warehouse.name}</td>
                                        <td className="text-center">
                                            <Link to={`/warehouse/edit/${warehouse.id}`} className="btn btn-warning btn-sm me-2">Edit</Link>
                                            <button onClick={() => handleDelete(warehouse.id)} className="btn btn-danger btn-sm">Delete</button>
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

export default Warehouses;
