import React, { useState } from 'react';

export default function Contact() {
  const [formData, setFormData] = useState({ name: '', email: '', message: '' });
  const [success, setSuccess] = useState(false);

  const handleChange = e => setFormData({ ...formData, [e.target.name]: e.target.value });

  const handleSubmit = async e => {
    e.preventDefault();
    const res = await fetch('/api/form', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(formData)
    });
    if (res.ok) {
      setSuccess(true);
      setFormData({ name: '', email: '', message: '' });
    }
  };

  return (
    <div>
      <h1>Kontakt</h1>
      {success && <div>Uspješno poslano!</div>}
      <form onSubmit={handleSubmit}>
        <div>
          <label>Email</label>
          <input name="email" type="email" value={formData.email} onChange={handleChange} required />
        </div>
        <div>
          <label>Ime</label>
          <input name="name" value={formData.name} onChange={handleChange} required />
        </div>
        <div>
          <label>Upit</label>
          <textarea name="message" value={formData.message} onChange={handleChange} rows="4" required />
        </div>
        <button type="submit">Pošalji</button>
      </form>
      <div style={{ marginTop: '10px' }}>
        <h5>Email - info@power-house.hr</h5>
      </div>
      {/* Style this page with your CSS or replace elements with your template */}
    </div>
  );
}
