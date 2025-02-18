import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import Products from "./pages/Products";
import ProductEdit from "./pages/ProductEdit";
import Warehouses from "./pages/Warehouses";
import WarehouseEdit from "./pages/WarehouseEdit";
import StockOverview from "./pages/StockOverview";
import Report from "./pages/Report";

function App() {
    return (
        <Router>
            <div className="container mt-3">
                {/* Navigation Buttons */}
                <div className="d-flex justify-content-center mb-4">
                    <div className="btn-group">
                        <Link to="/" className="btn btn-primary">Home</Link>
                        <Link to="/products" className="btn btn-primary">Products</Link>
                        <Link to="/warehouses" className="btn btn-primary">Warehouses</Link>
                        <Link to="/stock" className="btn btn-primary">Stock Overview</Link>
                        <Link to="/report" className="btn btn-primary">Report</Link>
                    </div>
                </div>

                {/* Page Routes */}
                <Routes>
                    <Route path="/products" element={<Products />} />
                    <Route path="/product/edit/:id" element={<ProductEdit />} />
                    <Route path="/warehouses" element={<Warehouses />} />
                    <Route path="/warehouse/edit/:id" element={<WarehouseEdit />} />
                    <Route path="/stock" element={<StockOverview />} />
                    <Route path="/report" element={<Report />} />
                </Routes>
            </div>
        </Router>
    );
}

export default App;
