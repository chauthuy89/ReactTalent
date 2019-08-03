import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';


export class FetchCustomer1 extends React.Component {
    displayName = FetchCustomer1.name
    constructor(props) {
        super(props);

        this.state = { custList: [], loading: true };
        fetch('api/Customer/Index')
            .then(response => response.json())
            .then(data => {
                this.setState({ custList: data, loading: false });
            });

        // This binding is necessary to make "this" work in the callback  

        this.handleDelete = this.handleDelete.bind(this);

        this.handleEdit = this.handleEdit.bind(this);
    }
   render() {

        let contents = this.state.loading

            ? <p><em>Loading...!!!!</em></p>

            : this.renderCustomerTable(this.state.custList);

        return <div>

            <h1>Customer Data</h1>

            <p>This component demonstrates fetching Customer data from the server.</p>

            <p>

                <Link to="/addcustomer">Create New</Link>

            </p>

            {contents}

        </div>;

    }



    // Handle Delete request for an customer  

 handleDelete(id) {

     if (!Window.confirm("Do you want to delete customer with Id: " + id))

            return;

        else {

            fetch('api/Customer/Delete/' + id, {

                method: 'delete'

            }).then(() => {

                this.setState(

                    {

                        custList: this.state.custList.filter((rec) => {

                            return (rec.customerId != id);

                        })

                    });

            });

        }

    }



    handleEdit(id) {

        this.props.history.push("/customer/edit/" + id);

    }



    // Returns the HTML table to the render() method.  

   renderCustomerTable(custList) {

        return <table className='table'>

            <thead>

                <tr>

                    <th></th>

                    <th>CustomerId</th>

                    <th>Name</th>

                    <th>Gender</th>

                </tr>

            </thead>

            <tbody>

                {custList.map(cust =>

                    <tr key={cust.customerId}>

                        <td></td>

                        <td>{cust.customerId}</td>

                        <td>{cust.name}</td>

                        <td>{cust.address}</td>


                        <td>

                            <a className="action" onClick={() => this.handleEdit(cust.customerId)}>Edit</a>  |

                            <a className="action" onClick={() => this.handleDelete(cust.customerId)}>Delete</a>

                        </td>

                    </tr>

                )}

            </tbody>

        </table>;

    }

}



